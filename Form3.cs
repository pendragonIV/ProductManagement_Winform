using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_C_
{
    public partial class Form3 : Form
    {

        Thread th;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userNameInput.Text.Trim().Equals("ngd_anh") && passwordInput.Text.Trim().Equals("1"))
            {
                
                this.Close();

                th = new Thread(productManagement);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                
            }
            else if (userNameInput.Text.Trim().Equals("") || passwordInput.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                userNameInput.Text = "";
                passwordInput.Text = "";

                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        public void productManagement(object obj)
        {
            Application.Run(new Form4());
        }
    }
}
