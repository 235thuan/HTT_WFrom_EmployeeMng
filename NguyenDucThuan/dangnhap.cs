using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDucThuan
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool checkLogin(string username, string password)
        {
            for (int i = 0; i < ListUser.Instance.ListUserA.Count; i++)
            {
                if(username==ListUser.Instance.ListUserA[i].Username
                    && password == ListUser.Instance.ListUserA[i].Password)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtTaikhoan.Text;
            string password = txtMatkhau.Text;
            if (checkLogin(username,password))
            {
                frmQuanlynv f = new frmQuanlynv();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không đúng mật khẩu hoặc tên đăng nhập.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
