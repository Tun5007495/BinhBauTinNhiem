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
    public partial class NhapDSUV : Form
    {
        private OracleConnection connection = OracleDatabaseConnection.GetConnection();
        private OracleCommand command = new OracleCommand();
        private List<string> selected_candidate = null;

        public NhapDSUV()
        {
            command.Connection = connection;
            InitializeComponent();
        }

        private void NhapDSUV_Load(object sender, EventArgs e)
        {
            this.selected_candidate = load_choosen_nv_MSNV();
            load_dsnv();
            load_unchoosen_nv();
            load_choosen_nv();
        }

        private void load_dsnv()
        {
            string query = "SELECT * FROM QLBC.NHANVIEN";
            command.CommandText = query;
            try
            {

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    DSNV_dgv.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void load_unchoosen_nv()
        {
            List<string> msnv_unchoosen = this.getUnchoosenNV_MSNV();
            foreach (string msnv in msnv_unchoosen)
            {

                unchoosenNV_lb.Items.Add(msnv);
            }
            unchoosenNV_lb.Refresh();
        }


        private List<String> getUnchoosenNV_MSNV()
        {
            string query = "SELECT nv.MANV FROM QLBC.NHANVIEN nv WHERE MANV NOT IN (SELECT MANV FROM QLBC.UNGVIEN) AND MANV NOT IN (SELECT MANV FROM QLBC.NHANVIEN_VANG)";
            command.CommandText = query;
            try
            {
                using (OracleDataReader reader = command.ExecuteReader())
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
        private void load_choosen_nv()
        {
            List<string> choosen_nv = this.load_choosen_nv_MSNV();
            foreach (string msnv in choosen_nv)
            {
                choosenNV_lb.Items.Add(msnv);
            }
            choosenNV_lb.Refresh();
        }
        private List<string> load_choosen_nv_MSNV()
        {
            string query = "SELECT MANV FROM QLBC.UNGVIEN";
            command.CommandText = query;
            try
            {
                using (OracleDataReader reader = command.ExecuteReader())
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var leftItems = unchoosenNV_lb.SelectedItem;
            if (leftItems != null)
            {
                choosenNV_lb.Items.Add(leftItems);
                unchoosenNV_lb.Items.Remove(leftItems);
                choosenNV_lb.Refresh();
                unchoosenNV_lb.Refresh();
            }
        }

        private void unchoose_btn_click(object sender, EventArgs e)
        {
            var rightItems = choosenNV_lb.SelectedItem;
            if (rightItems != null)
            {
                unchoosenNV_lb.Items.Add(rightItems);
                choosenNV_lb.Items.Remove(rightItems);
                choosenNV_lb.Refresh();
                unchoosenNV_lb.Refresh();
            }
        }

        private void unchoosenNV_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apply_btn_Click(object sender, EventArgs e)
        {

            IEnumerable<string> change_new = choosenNV_lb.Items.Cast<string>().ToList().Except(selected_candidate);
            IEnumerable<string> change_delete = selected_candidate.Except(choosenNV_lb.Items.Cast<string>().ToList());
            if (change_new.Any())
            {

                string insertQueryFormat = " INTO QLBC.UNGVIEN(MANV,SOPHIEU) VALUES ('{0}',0) ";
                List<string> queryInsert = new List<string>();
                foreach (var chnew in change_new)
                {
                    queryInsert.Add(String.Format(insertQueryFormat, chnew));
                }
                string query = "INSERT ALL ";
                string insertq = String.Join(" ", queryInsert);
                query += insertq;
                query += "SELECT 1 FROM DUAL";
                command.CommandText = query;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Candidates inserted successfully");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            if (change_delete.Any())
            {
                string delete_condition_format = "MANV = '{0}'";
                List<string> queryDelete = new List<string>();
                foreach (string chn_del in change_delete)
                {
                    queryDelete.Add(String.Format(delete_condition_format, chn_del));
                }
                string deleteCondition = String.Join(" OR ", queryDelete);
                string query = String.Format("DELETE FROM QLBC.UNGVIEN WHERE {0}", deleteCondition);
                command.CommandText = query;
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Candidates delete successfully");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void choosenNV_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
