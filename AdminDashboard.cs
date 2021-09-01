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

// Binh Bau
namespace BinhBauTinNhiem
{
    public partial class AdminDashboard : Form
    {
        private OracleConnection oracle = OracleDatabaseConnection.GetConnection();
        private OracleCommand oracleCommand = new OracleCommand();
        public AdminDashboard()
        {
            oracleCommand.Connection = oracle;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OracleConnection oracleConnection = OracleDatabaseConnection.GetConnection();
            OracleDatabaseConnection.CloseConnection();
            var loginForm = new Form1();
            loginForm.Show();
            this.Hide();
            loginForm.FormClosed += (s, args) => this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = dataGridView1.Rows[e.RowIndex];
            UserManagement userForm = new UserManagement(dataRow);
            userForm.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Shown(object sender, EventArgs e)
        {
            load_user();
            load_views();
            load_roles();
            load_tables();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
            createUserForm.FormClosed += CreateUserForm_FormClosed;
        }

        private void CreateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            load_user();
        }

        private void load_user()
        {
            
            try
            {
                oracleCommand.CommandText = "SELECT * FROM all_users";
                oracleCommand.Connection = oracle;
                using (DbDataReader dataReader = oracleCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataGridView1.DataSource = dataTable;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void load_roles()
        {
            try
            {
                oracleCommand.CommandText = "SELECT * FROM dba_roles";
                using (DbDataReader dataReader = oracleCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void load_tables()
        {
            try
            {
                oracleCommand.CommandText = "SELECT * FROM dba_tables";
                using (DbDataReader dataReader = oracleCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataGridView4.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void load_views()
        {
            try
            {
                oracleCommand.CommandText = "SELECT * FROM dba_views";
                using (DbDataReader dataReader = oracleCommand.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    dataGridView3.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RoleManagement form = new RoleManagement(dataGridView2.Rows[e.RowIndex]);
            form.Show();
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GrantPrivTable form = new GrantPrivTable(dataGridView4.Rows[e.RowIndex]);
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
