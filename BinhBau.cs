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
    public partial class BinhBau : Form
    {
        private string COMBOBOX_HEAD = "--Chọn ứng viên--";
        private OracleConnection oracle = OracleDatabaseConnection.GetConnection();
        private OracleCommand oracleCommand = new OracleCommand();
        private bool isUpdate = false;
        public BinhBau(bool isUpdate= false)
        {
            this.isUpdate = isUpdate;
            oracleCommand.Connection = oracle;
            InitializeComponent();
        }

        private void BinhBau_Load(object sender, EventArgs e)
        {
            LoadUngVien();
            loadUNGVIEN_to_combobox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadUngVien()
        {
            String query = "SELECT NV.* FROM QLBC.NDB_VIEW_UV UV INNER JOIN QLBC.NHANVIEN NV ON UV.MANV = NV.MANV";
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
        private void loadUNGVIEN_to_combobox()
        {
            uv1_cb.Items.Add(COMBOBOX_HEAD);
            uv2_cb.Items.Add(COMBOBOX_HEAD);
            uv3_cb.Items.Add(COMBOBOX_HEAD);
            List<string> dsuv = get_DSUV();
            foreach (string uv in dsuv)
            {
                uv1_cb.Items.Add(uv);
                uv2_cb.Items.Add(uv);
                uv3_cb.Items.Add(uv);
            }
            uv1_cb.Refresh();
            uv2_cb.Refresh();
            uv3_cb.Refresh();
        }
        private List<string> get_DSUV()
        {
            string query = "SELECT MANV FROM QLBC.NDB_VIEW_UV";
            oracleCommand.CommandText = query;
            try
            {
                using (OracleDataReader reader = oracleCommand.ExecuteReader())
                {
                    List<string> msnv_list = new List<string>();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        msnv_list.Add(row["MANV"].ToString());
                    }
                    return msnv_list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return new List<string>();
            }
        }

        private bool isValid_PhieuBau()
        {
            if (uv1_cb.SelectedIndex == 0 || uv2_cb.SelectedIndex == 0 || uv3_cb.SelectedIndex == 0)
            {
                return false;
            }
            else if (uv1_cb.SelectedIndex == uv2_cb.SelectedIndex || uv2_cb.SelectedIndex == uv3_cb.SelectedIndex || uv1_cb.SelectedIndex == uv3_cb.SelectedIndex)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bau_btn_Click(object sender, EventArgs e)
        {
            if (!isValid_PhieuBau())
            {
                MessageBox.Show("Phiếu bầu không hợp lệ");
                return;
            }
            string query = String.Format("INSERT INTO QLBC.PHIEUBAU (UV1, UV2, UV3) VALUES ('{0}', '{1}' , '{2}')", uv1_cb.SelectedItem, uv2_cb.SelectedItem, uv3_cb.SelectedItem);
            if (isUpdate)
            {
                query = String.Format("UPDATE QLBC.PHIEUBAU SET UV1 = '{0}', UV2 ='{1}', UV3 = '{2}', NGAYBAU = SYSDATE", uv1_cb.SelectedItem, uv2_cb.SelectedItem, uv3_cb.SelectedItem);
            }
            oracleCommand.CommandText = query;
            try
            {

            if (oracleCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Bầu thành công");
                Close();
            }
            else
            {
                MessageBox.Show("Bầu thất bại");
            }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
