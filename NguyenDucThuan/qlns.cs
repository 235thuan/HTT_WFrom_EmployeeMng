using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            txtManv.Enabled = true;
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
            string manv = txtManv.Text;
            frmCsttnv updateForm = new frmCsttnv(manv, this);
            updateForm.ShowDialog();
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

        public void LoadListEmployee()
        {

            try
            {
                using (SqlConnection con = connectDB())
                {
                    con.Open();
                    string query = "SELECT manv, hotennv, phongban, hesoluong, chucvu FROM nhanvien";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgvDsnv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dtgvDsnv.Rows.Clear();
            //foreach (var item in ListEmployee.Instance.Listempoy)
            //{
            //    dtgvDsnv.Rows.Add(item.MaNV, item.HoVaTen, item.NgaySinh.ToString("dd/MM/yyyy"),
            //        item.GioiTinh, item.PhongBan, item.ChucVu, item.TrangThai);
            //}
        }

        private void frmQuanlynv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wF_QL_nhanvienDataSet.nhanvien' table. You can move, or remove it, as needed.
            LoadListEmployee();
            this.nhanvienTableAdapter.Fill(this.wF_QL_nhanvienDataSet.nhanvien);
           
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
            //if (index < 0 || index >= ListEmployee.Instance.Listempoy.Count)
            //{
            //    MessageBox.Show("Hay chon 1 ban ghi");
            //    return;
            //}
            //ListEmployee.Instance.Listempoy.RemoveAt(index);
            //LoadListEmployee();
            string manvToDelete = txtManv.Text.Trim();
            if (!string.IsNullOrEmpty(manvToDelete))
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection con = connectDB())
                        {
                            con.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM nhanvien WHERE manv = @manv", con))
                            {
                                cmd.Parameters.AddWithValue("@manv", manvToDelete);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadListEmployee(); 
                                }
                                else
                                {
                                    MessageBox.Show("No employee found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

       
        private SqlConnection connectDB()
        {
            String strCon = "Server=DESKTOP-E43PI42\\MSSQLSERVER2017;Database=WF_QL_nhanvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
