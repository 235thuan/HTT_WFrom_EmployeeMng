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
    public partial class frmQuanlynv : Form
    {
        int index = -1;
        public frmQuanlynv()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaikhoan f = new frmTaikhoan();
            f.Show();
            this.Hide();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            dtgvDsnv.Visible = true;
            btnTimkiem.Enabled = true;
            txtHoten.Enabled = true;
            txtManv .Enabled = true;
            dtpNgaysinh.Enabled = true;
            cbxGioitinh.Enabled = true;
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongban f = new frmPhongban();
            f.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmCsttnv f = new frmCsttnv();
            f.FormClosed += F_formClosed1;
            f.ShowDialog();
        }

        private void F_formClosed1(object sender, FormClosedEventArgs e)
        {
            ListEmployee.Instance.Listempoy[index].HoVaTen = Const.newEmploy.HoVaTen;
            ListEmployee.Instance.Listempoy[index].NgaySinh = Const.newEmploy.NgaySinh;
            ListEmployee.Instance.Listempoy[index].GioiTinh = Const.newEmploy.GioiTinh;
            ListEmployee.Instance.Listempoy[index].MaNV = Const.newEmploy.MaNV;
            ListEmployee.Instance.Listempoy[index].PhongBan = Const.newEmploy.PhongBan;
            ListEmployee.Instance.Listempoy[index].ChucVu = Const.newEmploy.ChucVu;
            ListEmployee.Instance.Listempoy[index].TrangThai = Const.newEmploy.TrangThai;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Const.newEmploy = null;
            frmThemmoinv f = new frmThemmoinv();
            f.FormClosed += F_formClosed;
            f.ShowDialog();
        }

        private void F_formClosed(object sender, FormClosedEventArgs e)
        {
            ListEmployee.Instance.Listempoy.Add(Const.newEmploy);
            LoadListEmployee();
        }

        private void LoadListEmployee()
        {
            dtgvDsnv.Rows.Clear();
            foreach (var item in ListEmployee.Instance.Listempoy)
            {
                dtgvDsnv.Rows.Add(item.MaNV, item.HoVaTen, item.NgaySinh.ToString("dd/MM/yyyy"),
                    item.GioiTinh, item.PhongBan, item.ChucVu, item.TrangThai);
            }
        }

        private void frmQuanlynv_Load(object sender, EventArgs e)
        {
            LoadListEmployee();
            cbxGioitinh.DataSource = Const.listSex;
        }

        private void dtgvDsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= ListEmployee.Instance.Listempoy.Count)
                return;
            Const.newEmploy = new Employee();
            Const.newEmploy.HoVaTen = ListEmployee.Instance.Listempoy[index].HoVaTen;
            Const.newEmploy.NgaySinh = ListEmployee.Instance.Listempoy[index].NgaySinh;
            Const.newEmploy.GioiTinh = ListEmployee.Instance.Listempoy[index].GioiTinh;
            Const.newEmploy.MaNV = ListEmployee.Instance.Listempoy[index].MaNV;
            Const.newEmploy.PhongBan = ListEmployee.Instance.Listempoy[index].PhongBan;
            Const.newEmploy.ChucVu = ListEmployee.Instance.Listempoy[index].ChucVu;
            Const.newEmploy.TrangThai = ListEmployee.Instance.Listempoy[index].TrangThai;

            DataGridViewRow row = dtgvDsnv.Rows[index];
            txtManv.Text = row.Cells[0].Value.ToString();
            txtHoten.Text = row.Cells[1].Value.ToString();
            if (DateTime.TryParse(row.Cells[2].Value.ToString(), out DateTime dateValue))
            {
                dtpNgaysinh.Value = dateValue;
            }
            cbxGioitinh.SelectedItem = row.Cells[3].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListEmployee.Instance.Listempoy.Count)
            {
                MessageBox.Show("Hay chon 1 ban ghi");
                return;
            }
            ListEmployee.Instance.Listempoy.RemoveAt(index);
            LoadListEmployee();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string manv = txtManv.Text.Trim();
            string hoten = txtHoten.Text.Trim();
            DateTime ngaysinh = dtpNgaysinh.Value;
            string gioitinh = cbxGioitinh.SelectedItem?.ToString();

            bool matchFound = false;

            foreach (DataGridViewRow row in dtgvDsnv.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                string rowManv = row.Cells[0].Value?.ToString(); // Assuming MaNV is in the first column
                string rowHoten = row.Cells[1].Value?.ToString(); // Assuming HoVaTen is in the second column
                DateTime rowNgaySinh = DateTime.ParseExact(row.Cells[2].Value.ToString(), "dd/MM/yyyy", null); // Assuming NgaySinh is in the third column
                string rowGioiTinh = row.Cells[3].Value?.ToString(); // Assuming GioiTinh is in the fourth column

                if (!string.IsNullOrEmpty(manv) && rowManv.Equals(manv, StringComparison.OrdinalIgnoreCase))
                {
                    dtgvDsnv.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    matchFound = true;
                    break;
                }

                if (!string.IsNullOrEmpty(hoten) && rowHoten.IndexOf(hoten, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    dtgvDsnv.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    matchFound = true;
                    break;
                }

                if (ngaysinh != DateTime.MinValue && rowNgaySinh.Date == ngaysinh.Date)
                {
                    dtgvDsnv.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    matchFound = true;
                    break;
                }

                if (!string.IsNullOrEmpty(gioitinh) && rowGioiTinh.Equals(gioitinh, StringComparison.OrdinalIgnoreCase))
                {
                    dtgvDsnv.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    matchFound = true;
                    break;
                }
            }


            if (!matchFound)
            {
                MessageBox.Show("No matching record found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvDsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
