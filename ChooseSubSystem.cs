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
    public partial class ChooseSubSystem : Form
    {
        OracleConnection connection = OracleDatabaseConnection.GetConnection();
        OracleCommand oracleCommand = new OracleCommand();
        public ChooseSubSystem()
        {
            oracleCommand.Connection = connection;
            InitializeComponent();
        }

        private void ChooseSubSystem_Load(object sender, EventArgs e)
        {
            textBox1.Text = UserUtils.username;
            textBox1.Enabled = false;
            List<String> roles = getUserRoles();
            if (!roles.Contains("DBA"))
            {
                AdminSubSys.Enabled = false;
            }
            if (UserUtils.username != "QLBC")
            {
                TruongBanToChucBinhBauSS.Enabled = false;
            }
            if (!roles.Contains("NGUOIDIBAU"))
            {
                NguoiDiBauSS.Enabled = false;
            }
            if (!roles.Contains("BTC"))
            {
                BanToChucBinhBauSS.Enabled = false;
            }
            if (!roles.Contains("TOGIAMSAT"))
            {
                ToGiamSatSS.Enabled = false;
            }
            if (!roles.Contains("TOLAPDS"))
            {
                ToLapDSNDB_SS.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private List<String> getUserRoles()
        {
            String query = "SELECT GRANTED_ROLE FROM user_role_privs";
            oracleCommand.CommandText = query;
            try
            {
                List<String> roles = new List<String>();
                using (OracleDataReader dataReader = oracleCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        roles.Add(dataReader.GetString(0));
                    }
                }
                return roles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return new List<String>();
            }
        }

        private void AdminSubSys_Click(object sender, EventArgs e)
        {
            AdminDashboard admin = new AdminDashboard();
            admin.FormClosed += Admin_FormClosed;
            admin.Show();
            Hide();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ToLapDSNDB_SS_Click(object sender, EventArgs e)
        {

        }

        private void TruongBanToChucBinhBauSS_Click(object sender, EventArgs e)
        {
            TruongBanSubSys form = new TruongBanSubSys();
            form.Show();
            form.FormClosed += Form_FormClosed;
            Hide();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NguoiDiBauSS_Click(object sender, EventArgs e)
        {
            NguoiDiBauSubSys form = new NguoiDiBauSubSys();
            form.Show();
            form.FormClosed += Form_FormClosed1;
            Hide();
        }

        private void Form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
