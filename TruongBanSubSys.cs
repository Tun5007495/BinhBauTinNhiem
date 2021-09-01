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
    public partial class TruongBanSubSys : Form
    {
        private OracleConnection oracle = OracleDatabaseConnection.GetConnection();
        private OracleCommand oracleCommand = new OracleCommand();

        public TruongBanSubSys()
        {
            oracleCommand.Connection = oracle;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhapDSUV nhapDSUV = new NhapDSUV();
            nhapDSUV.FormClosed += NhapDSUV_FormClosed;
            nhapDSUV.Show();

        }

        private void NhapDSUV_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadUngVien();
        }

        private void TruongBanSubSys_Load(object sender, EventArgs e)
        {
            LoadUngVien();
        }
        private void LoadUngVien()
        {
            String query = "SELECT NV.*, UV.SOPHIEU FROM QLBC.UNGVIEN UV INNER JOIN QLBC.NHANVIEN NV ON UV.MANV = NV.MANV";
            oracleCommand.CommandText = query;
            try
            {
                using (OracleDataReader reader = oracleCommand.ExecuteReader())
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
