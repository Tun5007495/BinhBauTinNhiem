using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinhBauTinNhiem
{
    public partial class GrantPrivTable : Form
    {
        OracleConnection connection = OracleDatabaseConnection.GetConnection();
        OracleCommand command;

        DataTable table_priv = new DataTable("table_priv");
        String tableName;
        String owner;
        DataGridViewRow data;

        public GrantPrivTable(DataGridViewRow row)
        {
            data = row;
            tableName = data.Cells["TABLE_NAME"].Value.ToString();
            owner = data.Cells["OWNER"].Value.ToString();
            command = connection.CreateCommand();
            InitializeComponent();

        }

        private void GrantPrivTable_Load(object sender, EventArgs e)
        {

        }

        private void GrantPrivTable_Shown(object sender, EventArgs e)
        {
            tablename.Text = tableName;
            load_table_priv();
            load_unSelected_user();
        }

        private void load_table_priv()
        {
            ArrayList cols = getColumns();
            table_priv.Columns.Add("Column", typeof(string));
            table_priv.Columns["Column"].ReadOnly = true;
            table_priv.Columns.Add("GRANT", typeof(bool));
            foreach (var col in cols)
            {
                table_priv.Rows.Add(col.ToString(), false);
            }
            cols_privs.DataSource = table_priv;
            foreach (DataGridViewColumn column in cols_privs.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void load_unSelected_user()
        {
            ArrayList users = getUsers();
            foreach (string user in users)
            {
                listBox1.Items.Add(user);
            }
        }



        private ArrayList getColumns()
        {
            command.CommandText = String.Format("SELECT COLUMN_NAME FROM DBA_TAB_COLS WHERE TABLE_NAME='{0}'", tableName);
            try
            {
                using (DbDataReader reader = command.ExecuteReader())
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    var cols = new ArrayList();
                    foreach (DataRow col in data.Rows)
                    {
                        cols.Add(col["COLUMN_NAME"]);
                    }
                    return cols;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return new ArrayList();
            }
        }
        private ArrayList getUsers()
        {
            var users = new ArrayList();
            command.CommandText = "SELECT USERNAME FROM all_users";
            try
            {
                using (DbDataReader reader = command.ExecuteReader())
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    foreach (DataRow user in data.Rows)
                    {
                        users.Add(user["USERNAME"]);
                    }
                }
                command.CommandText = "SELECT ROLE FROM DBA_ROLES";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    foreach (DataRow user in data.Rows)
                    {
                        users.Add(user["ROLE"]);
                    }
                }
                return users;
            }
            catch (Exception ex)
            {
                return new ArrayList();
            }
        }

        private void unselected_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            var itemleft = listBox1.SelectedItem;
            if (itemleft != null)
            {

                listBox2.Items.Add(itemleft);
                listBox1.Items.Remove(itemleft);
            }
            listBox1.Refresh();
            listBox2.Refresh();

        }

        private void unselect_btn_Click(object sender, EventArgs e)
        {
            var itemright = listBox2.SelectedItem;
            if (itemright != null)
            {
                listBox2.Items.Remove(itemright);
                listBox1.Items.Add(itemright);
            }
            listBox1.Refresh();
            listBox2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Are you sure?", "Grant privileges?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                List<string> users = new List<string>();
                foreach (string user in listBox2.Items)
                {
                    users.Add(user);
                }
                string users_str = String.Join(", ", users);


                List<string> priviledge = new List<string>();
                if (checkBox1.Checked) priviledge.Add("SELECT");
                if (insert_check.Checked) priviledge.Add("INSERT");
                if (delete_check.Checked) priviledge.Add("DELETE");
                List<string> columnPri = new List<string>();
                foreach (DataRow row in table_priv.Rows)
                {
                    if (row.Field<bool>("GRANT") == true)
                    {
                        columnPri.Add(row.Field<string>(0));
                    }
                }
                string updatepriv = null;
                if (columnPri.Count > 0)
                {
                    updatepriv = "UPDATE (" + string.Join(",", columnPri) + ") ";
                }
                if (updatepriv != null)
                    priviledge.Add(updatepriv);
                string privileges = String.Join(", ", priviledge);
                string query = String.Format("GRANT {0} ON {1}.{2} TO {3}", privileges,owner, tableName, users_str);
                command.CommandText = query;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show(this, "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message.ToString());
                }
            }
        }

        private void cols_privs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
