using Oracle.ManagedDataAccess.Client;
using System;
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
    public partial class UserManagement : Form
    {
        OracleConnection connection = OracleDatabaseConnection.GetConnection();
        OracleCommand oracleCommand = new OracleCommand();
        String username;
        private DataGridViewRow data;
        public UserManagement(DataGridViewRow data)
        {
            this.data = data;
            username = data.Cells[0].Value.ToString();
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void UserManagement_Shown(object sender, EventArgs e)
        {
            oracleCommand.Connection = connection;
            textBox1.Text = username;
            load_granted_roles();
            load_granted_table();
            load_granted_cols();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void load_granted_roles()
        {
            try
            {
                String form = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{0}'";
                String query = String.Format(form, username);
                oracleCommand.CommandText = query;
                using (DbDataReader reader = oracleCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                this.Close();
            }
        }

        private void load_granted_table()
        {
            try
            {
                String form = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '{0}'";
                String query = String.Format(form, username);
                oracleCommand.CommandText = query;
                using (DbDataReader reader = oracleCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                this.Close();
            }
        }
        private void load_granted_cols()
        {
            try
            {
                String form = "SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = '{0}'";
                String query = String.Format(form, username);
                oracleCommand.CommandText = query;
                using (DbDataReader reader = oracleCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView3.DataSource = dataTable;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                this.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                int privilegeIndex = dataGridView1.Columns["PRIVILEGE"].Index;
                int userIndex = dataGridView1.Columns["GRANTEE"].Index;
                int tableIndex = dataGridView1.Columns["TABLE_NAME"].Index;


                String user = dataGridView1.SelectedRows[0].Cells[userIndex].Value.ToString();
                String table = dataGridView1.SelectedRows[0].Cells[tableIndex].Value.ToString();
                String priv = dataGridView1.SelectedRows[0].Cells[privilegeIndex].Value.ToString();

                String query = String.Format("REVOKE {0} ON {1} FROM {2}", priv, table, user);
                oracleCommand.CommandText = query;
                DialogResult dialog = MessageBox.Show("Are you sure to revoke " + priv + " on " + table + " from " + user, "Revoke?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        oracleCommand.ExecuteNonQuery();
                        MessageBox.Show(this, "Revoke role successfully", "Success");
                        load_granted_roles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                String user = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                String role = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                String query = String.Format("REVOKE {0} FROM {1}", role, user);
                oracleCommand.CommandText = query;
                DialogResult dialog = MessageBox.Show("Are you sure to revoke " + role + " from " + user, "Revoke?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        oracleCommand.ExecuteNonQuery();
                        MessageBox.Show(this, "Revoke role successfully", "Success");
                        load_granted_roles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView3.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                String priv = dataGridView3.SelectedRows[0].Cells["PRIVILEGE"].Value.ToString();
                string tablename = dataGridView3.SelectedRows[0].Cells["TABLE_NAME"].Value.ToString();
                String query = String.Format("REVOKE {0} ON {1} FROM {2}", priv, tablename, username);
                oracleCommand.CommandText = query;
                DialogResult dialog = MessageBox.Show("Are you sure to revoke " + priv + " on " + tablename + " from " + username, "Revoke?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        oracleCommand.ExecuteNonQuery();
                        MessageBox.Show(this, "Revoke successfully", "Success");
                        load_granted_cols();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                    }
                }
            }
        }
    }
}
