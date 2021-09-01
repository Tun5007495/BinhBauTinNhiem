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
    public partial class NguoiDiBauSubSys : Form
    {

        private OracleConnection connection = OracleDatabaseConnection.GetConnection();
        private OracleCommand command = new OracleCommand();
        public NguoiDiBauSubSys()
        {
            command.Connection = connection;
            InitializeComponent();
            loadPhieuBau();
        }
        private void loadPhieuBau()
        {
            string query = "SELECT * FROM QLBC.PHIEUBAU";
            command.CommandText = query;
            try
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BinhBau binhBau = new BinhBau();
            binhBau.FormClosed += BinhBau_FormClosed;
            binhBau.Show();
        }

        private void BinhBau_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadPhieuBau();
        }

        private void NguoiDiBauSubSys_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BinhBau binhBau = new BinhBau(true);
            binhBau.Show();
            binhBau.FormClosed += BinhBau_FormClosed1;
        }

        private void BinhBau_FormClosed1(object sender, FormClosedEventArgs e)
        {
            loadPhieuBau();
        }
    }
}
