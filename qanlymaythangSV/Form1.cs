using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qanlymaythangSV
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool CheckLogin(string userName, string password)
        {
            for(int i = 0; i < ListUser.Instance.ListAccountUser.Count; i++) 
            {
                if(userName == ListUser.Instance.ListAccountUser[i].UserName && password == ListUser.Instance.ListAccountUser[i].Password)
                   return true;
            }

            return false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassWord.Text;

            if(CheckLogin(userName, password))
            {
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
                frm.Loguot += Frm_Loguot;
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "Loi", MessageBoxButtons.OK);
                txbUserName.Focus();
                return;
            }
            
        }

        private void Frm_Loguot(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ckbShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassWord.Checked)
                txbPassWord.UseSystemPasswordChar = false;

            if (!ckbShowPassWord.Checked)
                txbPassWord.UseSystemPasswordChar = true;
        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
