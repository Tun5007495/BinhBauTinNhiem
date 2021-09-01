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
    public partial class RoleManagement : Form
    {
        OracleConnection connection = OracleDatabaseConnection.GetConnection();
        OracleCommand command = new OracleCommand();
        DataGridViewRow data;
        String role;
        public RoleManagement(DataGridViewRow row)
        {
            data = row;
            role = row.Cells["ROLE"].Value.ToString();
            InitializeComponent();
            command.Connection = connection;
        }

        private void RoleManagement_Load(object sender, EventArgs e)
        {

        }

        private void RoleManagement_Shown(object sender, EventArgs e)
        {
            load_granted_tables();
            load_granted_cols();
            load_unSelected_user();
        }
        private void load_granted_tables()
        {
            String query = String.Format("SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE='{0}'", role);
            command.CommandText = query;
            try
            {
                using (DbDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    grant_tabs.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "Error");
            }

        }
        private void load_granted_cols()
        {
            String query = String.Format("SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE='{0}'", role);
            command.CommandText = query;
            try
            {
                using (DbDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    grant_cols.DataSource= dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "Error");
            }
        }

        private void grant_tabs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void choose_Click(object sender, EventArgs e)
        {
            var itemleft = ungranted.SelectedItem;
            if (itemleft != null)
            {
                granted.Items.Add(itemleft);
                ungranted.Items.Remove(itemleft);
            }
            granted.Refresh();
            ungranted.Refresh();
        }

        private void unchoose_Click(object sender, EventArgs e)
        {
            var itemright = granted.SelectedItem;
            if (itemright != null)
            {
                ungranted.Items.Add(itemright);
                granted.Items.Remove(itemright);
            }
            granted.Refresh();
            ungranted.Refresh();
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
                return users;
            }
            catch (Exception ex)
            {
                return new ArrayList();
            }
        }
        private void load_unSelected_user()
        {
            ArrayList users = getUsers();
            foreach (string user in users)
            {
                ungranted.Items.Add(user);
            }
        }

        private void grant_cols_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void revoke_tab_btn_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = grant_tabs.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                int privilegeIndex = grant_tabs.Columns["PRIVILEGE"].Index;
                int userIndex = grant_tabs.Columns["GRANTEE"].Index;
                int tableIndex = grant_tabs.Columns["TABLE_NAME"].Index;


                String user = grant_tabs.SelectedRows[0].Cells[userIndex].Value.ToString();
                String table = grant_tabs.SelectedRows[0].Cells[tableIndex].Value.ToString();
                String priv = grant_tabs.SelectedRows[0].Cells[privilegeIndex].Value.ToString();

                String query = String.Format("REVOKE {0} ON {1} FROM {2}", priv, table, user);
                command.CommandText = query;
                DialogResult dialog = MessageBox.Show("Are you sure to revoke " + priv + " on " + table + " from " + user, "Revoke?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show(this, "Revoke role successfully", "Success");
                        load_granted_tables();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "Error");
                    }
                }
            }
        }

        private void revoke_col_btn_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = grant_cols.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                String priv = grant_cols.SelectedRows[0].Cells["PRIVILEGE"].Value.ToString();
                string tablename = grant_cols.SelectedRows[0].Cells["TABLE_NAME"].Value.ToString();
                String query = String.Format("REVOKE {0} ON {1} FROM {2}",priv,tablename, role);
                command.CommandText = query;
                DialogResult dialog = MessageBox.Show("Are you sure to revoke " +priv+" on "+tablename+" from " + role, "Revoke?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        command.ExecuteNonQuery();
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

        private void grant_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Are you sure?", "Grant privileges?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                List<string> users = new List<string>();
                foreach (string user in granted.Items)
                {
                    users.Add(user);
                }
                string users_str = String.Join(", ", users);

                string query = String.Format("GRANT {0} TO {1}", role, users_str);
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
    }
}
