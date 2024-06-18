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
    public partial class frmTaikhoan : Form
    {
        private ListUser listUser;
        public frmTaikhoan()
        {
            InitializeComponent();
            listUser = new ListUser();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTaikhoan_Load(object sender, EventArgs e)
        {
            loadDtgv();
        }
        private void loadDtgv()
        {
            dtgvTk.DataSource = null;
            dtgvTk.DataSource = listUser.GetUsers();
        }
    }
}
