using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYHT
{
    public partial class Form1 : Form
    {
        public TextBox TxtUsername
        {
            get { return txtUsername; }
            set { txtUsername = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap dn = new KiemTraDangNhap();
            MainForm frm = new MainForm(this);
            if (dn.CheckLogin(txtUsername.Text, txtPassword.Text) == 1)
            {
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                lblThongBao.Text = "Sai Password hoac Username. Check lai lan nua !!!";
                txtUsername.Clear();
                txtPassword.Clear();
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
