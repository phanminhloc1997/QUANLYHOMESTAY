using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace QUANLYHT
{
    public partial class MainForm : Form
    {
        Form1 f;
        public MainForm(Form1 f)
        {
            //f = new Form1();  // ban co truyen dau, tu nhien new
            this.f = f;
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile(this.f);
            pf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            KetNoi();
            Form1 frmDN = new Form1();
            frmDN.Show();

            string p1 = f.TxtUsername.Text;
            lblThongBao.Text = p1 + " đăng nhập thành công";

            SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
            string sql = "select * from PHONG";
            SqlDataAdapter ad = new SqlDataAdapter(sql, kn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cbPhong.DataSource = dt;
            cbPhong.DisplayMember = "TENPHONG";
            cbPhong.ValueMember = "MAPHONG";
            if (this.txtPhong.Text == "System.Data.DataRowView")
                txtPhong.Text = "";
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtPhong.Text = cbPhong.SelectedValue.ToString();
        }

        private void KetNoi()
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Open();
                string sql = "select * from PHIEUDANGKY";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                SqlDataAdapter com = new SqlDataAdapter(commandsql);
                DataTable table = new DataTable();
                com.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch
            {
                MessageBox.Show("LỖI KẾT NỐI VUI LÒNG KIỂM TRA LẠI!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Close();
            }
        }

        
        int index;

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtPhieuDK.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtNgayDat.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtNgayTra.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtPhong.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            cbPhong.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtTienCoc.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }

        string them;
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Open();
                them = "INSERT INTO PHIEUDANGKY VALUES('" + txtPhieuDK.Text + "','" + txtKH.Text + "','" + txtNgayDat.Text + "','" + txtNgayTra.Text + "','" + txtPhong.Text + "','" + cbPhong.Text + "','" + txtTienCoc.Text + "')";
                SqlCommand commandthem = new SqlCommand(them, kn);
                commandthem.ExecuteNonQuery();
                KetNoi();
                MessageBox.Show("THÊM THÀNH CÔNG");
            }
            catch
            {
                MessageBox.Show("LỖI KHÔNG THÊM ĐƯỢC!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Close();
            }
        }

        string XoaPhieuDK;
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Open();
                XoaPhieuDK = "delete PHIEUDANGKY where MAPDK = '" + txtPhieuDK.Text + "'";
                SqlCommand conn = new SqlCommand(XoaPhieuDK, kn);
                conn.ExecuteNonQuery();
                KetNoi();
                MessageBox.Show("XÓA THÀNH CÔNG");
            }
            catch
            {
                MessageBox.Show("LỖI KHÔNG XÓA ĐƯỢC!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Close();
            }
        }

        string Sua;
        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Open();
                Sua = "update PHIEUDANGKY set USERNAME='" + txtKH.Text + "',NGAYDAT='" + txtNgayDat.Text + "',NGAYTRA='" + txtNgayTra.Text + "',MAPHONG='" + txtPhong.Text + "',TENPHONG='"+cbPhong.Text+"',TIENCOC='"+txtTienCoc.Text+"' where MAPDK = '"+txtPhieuDK.Text+"'";
                SqlCommand commandsua = new SqlCommand(Sua, kn);
                commandsua.ExecuteNonQuery();
                KetNoi();
                MessageBox.Show("SỬA THÀNH CÔNG");
            }
            catch
            {
                MessageBox.Show("LỖI KHÔNG SỬA ĐƯỢC!");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-S0LV1V2\SQLEXPRESS;Initial Catalog=QLHOMESTAY;Integrated Security=True");
                kn.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        

       


        

       

        
    }
}
