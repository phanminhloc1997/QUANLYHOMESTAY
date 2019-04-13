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
    public partial class DangKy : Form
    {
        
    
        AccessData acc;

        public DangKy()
        {
            InitializeComponent();
            for (int i = 1; i <= 31; i++)
            {
                this.cbDate.Items.Add(i.ToString());
            }

            for (int i = 0; i <= 12; i++)
            {
                this.cbMonth.Items.Add(i.ToString());
            }

            int curYear = DateTime.Now.Year;
            for (int i = curYear; i >= 1900; i--)
            {
                this.cbYear.Items.Add(i.ToString());
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Ngay n = new Ngay();
            if (n.KiemTraHopLe(cbDate, cbMonth, cbYear) == 1)
            {
                acc = new AccessData();
                string gender = "";
                string birth = "";
                if (this.rdMale.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    if (this.rdFemale.Checked == true)
                    {
                        gender = "Female";
                    }
                }
                //
                birth = cbDate.SelectedItem.ToString() + "/" + cbMonth.SelectedItem.ToString() + "/" + cbYear.SelectedItem.ToString();
                //
                string sql = "INSERT INTO USER_INFO VALUES('" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtCPassword.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + gender + "', '" + birth + "','" + txtOccupation.Text + "')";
                acc.ExcuteNonQuery(sql);
                MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
            else
            {
                cbDate.Text = "Date:";
                cbMonth.Text = "Month:";
                cbYear.Text = "Year:";
            }
        }

        private void ClearTextBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtCPassword.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            cbDate.Text = "Day:";
            cbMonth.Text = "Month:";
            cbYear.Text = "Year:";
            txtOccupation.Clear();
        }

        
    }
}
