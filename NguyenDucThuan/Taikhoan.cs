using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDucThuan
{
    public partial class frmTaikhoan : Form
    {
        int index = -1;
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
            cbxLoaitk.DataSource = Const.listLoaiTK;
        }
        private void loadDtgv()
        {
            //dtgvTk.DataSource = null;
            //dtgvTk.DataSource = listUser.GetUsers();
            dtgvTk.Rows.Clear();
            foreach (var item in listUser.GetUsers())
            {
                dtgvTk.Rows.Add(item.Username, item.Password, item.TypeOfAccount);
            }
        }

        private void dtgvTk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListUser.Instance.ListUserA.Count)
                return;
            Const.newUser = new User();
            Const.newUser.Username = ListUser.Instance.ListUserA[index].Username;
            Const.newUser.Password = ListUser.Instance.ListUserA[index].Password;
            Const.newUser.TypeOfAccount = ListUser.Instance.ListUserA[index].TypeOfAccount;
            dtgvTk.Columns.Clear();
            dtgvTk.Columns.Add("UsernameColumn", "Username");
            dtgvTk.Columns.Add("PasswordColumn", "Password");
            dtgvTk.Columns.Add("AccountTypeColumn", "Account Type");
            loadDtgv();
            DataGridViewRow row = dtgvTk.Rows[index];
            txtTentk.Text = row.Cells[0].Value.ToString();
            txtMatkhau.Text = row.Cells[1].Value.ToString();
            object cellValue = row.Cells[2].Value;
            if (cellValue != null)
            {
                cbxLoaitk.SelectedItem = cellValue.ToString();
            }
            else
            {
                cbxLoaitk.SelectedItem = null;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTk = txtTentk.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            string loaiTk = cbxLoaitk.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(tenTk)&& !string.IsNullOrEmpty(mk)&& !string.IsNullOrEmpty(loaiTk))
            {
                listUser.CreateUserWithType(tenTk,mk,loaiTk);
                txtTentk.Text = "";
                txtMatkhau.Text = "";
                loadDtgv();
                Const.newUser = new User(tenTk,mk,loaiTk);
            }
            else
            {
                MessageBox.Show("Please enter value");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenTk = txtTentk.Text.Trim();
            string mk = txtMatkhau.Text.Trim();
            string loaiTk = cbxLoaitk.SelectedItem?.ToString();
            listUser.UpdatePasswordWithType(tenTk, mk, loaiTk);
            loadDtgv() ;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenTk = txtTentk.Text.Trim();
            listUser.DeleteUser(tenTk);
        }
    }
}
