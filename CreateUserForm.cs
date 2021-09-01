using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinhBauTinNhiem
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            String passwordRetype = textBox3.Text;
            if (password != passwordRetype)
            {
                MessageBox.Show("Password retype is not the same with password");
                return;
            }
            else
            {
                OracleConnection connection = OracleDatabaseConnection.GetConnection();
                OracleCommand oracleCommand = connection.CreateCommand();
                oracleCommand.CommandText = String.Format("CREATE USER {0} IDENTIFIED BY {1}", username, password);
                try
                {
                    oracleCommand.ExecuteNonQuery();
                    oracleCommand.CommandText = String.Format("GRANT CREATE SESSION TO {0}", username);
                    oracleCommand.ExecuteNonQuery();
                    MessageBox.Show(String.Format("User {0} created successfully", username));
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
