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
    public partial class Profile : Form
    {
        Form1 frm1 = null;

        public Profile(Form1 f)
        {
            this.frm1 = f;
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


        private void Profile_Load(object sender, EventArgs e)
        {
            AccessData acc = new AccessData();

            string frmUsername = frm1.TxtUsername.Text;

            SqlDataReader reader = acc.ExecuteReader("SELECT * FROM USER_INFO WHERE USERNAME = '" + frmUsername + "'");

            while (reader.Read())
            {
                txtUsername.Text = reader[0].ToString();
                txtPassword.Text = reader[1].ToString();
                txtCPassword.Text = reader[2].ToString();
                txtEmail.Text = reader[3].ToString();
                txtAddress.Text = reader[4].ToString();
                txtOccupation.Text = reader[7].ToString();
                //
                if (reader[5].ToString() == "Male")
                {
                    rdMale.Checked = true;
                }
                else
                {
                    if (reader[5].ToString() == "Female")
                    {
                        rdFemale.Checked = true;
                    }
                }
                //
                string birth = reader[6].ToString();
                string[] arrBirth = birth.Split('/');
                cbDate.Text = arrBirth[0];
                cbMonth.Text = arrBirth[1];
                cbYear.Text = arrBirth[2];

            }
            reader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Ngay n = new Ngay();
                if (n.KiemTraHopLe(cbDate, cbMonth, cbYear) == 1)
                {
                    AccessData acc = new AccessData();

                    string username = frm1.TxtUsername.Text;
                    string gender = "";

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
                    string birth = "";
                    birth = cbDate.SelectedItem.ToString() + "/" + cbMonth.SelectedItem.ToString() + "/" + cbYear.SelectedItem.ToString();

                    string sql = "UPDATE USER_INFO SET PASSWORD = '" + txtPassword.Text + "', CPASSWORD = '" + txtCPassword.Text + "', EMAIL = '" + txtEmail.Text + "', ADDRESS = '" + txtAddress.Text + "', GENDER = '" + gender + "', BIRTHDAY = '" + birth + "', OCCUPATION = '" + txtOccupation.Text + "' WHERE USERNAME = '" + username + "'";
                    acc.ExcuteNonQuery(sql);
                    MessageBox.Show("Update Successfully !!!");
                    this.Refresh();
                }
                else
                {
                    cbDate.Text = "Date:";
                    cbMonth.Text = "Month:";
                    cbYear.Text = "Year:";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!");
            }
        }

       
    }
}
