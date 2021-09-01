using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BinhBauTinNhiem
{
    public partial class Form1 : Form
    {
        private OracleConnection oracle;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string username = textBox1.Text;
            string password = textBox2.Text;
            oracle = OracleDatabaseConnection.Login(username, password);
            if (oracle != null)
            {

                OracleCommand command = oracle.CreateCommand();

                command.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                var myForm = new ChooseSubSystem();
                myForm.FormClosed += MyForm_FormClosed;
                myForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Database login failed");
                button1.Enabled = true;
            }
        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
