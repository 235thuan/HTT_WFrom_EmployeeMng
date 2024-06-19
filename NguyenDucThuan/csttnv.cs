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
    public partial class frmCsttnv : Form
    {
        private string _manv;
        private frmQuanlynv _parentForm;
        public frmCsttnv(string manv, frmQuanlynv parentForm)
        {
            InitializeComponent();
            _manv = manv;
            _parentForm = parentForm;
        }
        void LoadInfor( string manv)
        {

            try
            {
                using (SqlConnection con = connectDB())
                {
                    con.Open();
                    string query = "SELECT manv, hotennv, phongban, hesoluong, chucvu FROM nhanvien WHERE manv = @manv";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@manv", manv);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtManhanvien.Text = reader["manv"].ToString();
                                txtHoten.Text = reader["hotennv"].ToString();
                                cbxPhongban.Text = reader["phongban"].ToString();
                                txtLuong.Text = reader["hesoluong"].ToString();
                                txtChucvu.Text = reader["chucvu"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Employee not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbxGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmCsttnv_Load(object sender, EventArgs e)
        {
            cbxGioitinh.DataSource = Const.listSex;
            cbxPhongban.DataSource = Const.listDepartment;
            cbxTrangthai.DataSource = Const.listTrangthai;
            LoadInfor(_manv);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = connectDB())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"UPDATE nhanvien 
                                                 SET hotennv = @hotennv, 
                                                     phongban = @phongban, 
                                                     hesoluong = @hesoluong, 
                                                     chucvu = @chucvu 
                                                 WHERE manv = @manv", con))
                    {
                        cmd.Parameters.AddWithValue("@manv", txtManhanvien.Text.Trim());
                        cmd.Parameters.AddWithValue("@hotennv", txtHoten.Text.Trim());
                        cmd.Parameters.AddWithValue("@phongban", cbxPhongban.Text);
                        cmd.Parameters.AddWithValue("@hesoluong", float.Parse(txtLuong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@chucvu", txtChucvu.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cap nhat thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _parentForm.LoadListEmployee(); ;
                        }
                        else
                        {
                            MessageBox.Show("Khong co nhan vien nao duoc cap nhat", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi cap nhat " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            frmQuanlynv frm = new frmQuanlynv();
            frm.Refresh(); 
        }

        private SqlConnection connectDB()
        {
            String strCon = "Server=DESKTOP-E43PI42\\MSSQLSERVER2017;Database=WF_QL_nhanvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }
    }
}
