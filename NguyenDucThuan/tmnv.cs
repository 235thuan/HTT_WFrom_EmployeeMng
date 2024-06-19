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
    public partial class frmThemmoinv : Form
    {
        public frmThemmoinv()
        {
            InitializeComponent();
        }
     
        private void frmThemmoinv_Load(object sender, EventArgs e)
        {
            cbxGioitinh.DataSource = Const.listSex;
            cbxPhongban.DataSource = Const.listDepartment;
            cbxTrangthai.DataSource = Const.listTrangthai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string name=txtHoten.Text.Trim();
            //int maNv = int.Parse(txtManhanvien.Text.Trim()); 
            //DateTime birthday = dtpNgaysinh.Value;
            //string sex = cbxGioitinh.Text;
            //string department = cbxPhongban.Text;
            //string position = txtChucvu.Text;
            //float hesoluong =float.Parse(txtLuong.Text.Trim());
            //string status = cbxTrangthai.Text;
            //Const.newEmploy = new Employee(maNv,name, birthday, sex, maNv, department, position, status);

            try
            {
                using (SqlConnection con = connectDB())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO nhanvien (manv, hotennv,phongban,hesoluong,chucvu) VALUES (@manv, @hotennv,@phongban,@hesoluong,@chucvu)", con))
                    {
                        cmd.Parameters.AddWithValue("@manv", txtManhanvien.Text.Trim());
                        cmd.Parameters.AddWithValue("@hotennv", txtHoten.Text.Trim());
                        cmd.Parameters.AddWithValue("@phongban", cbxPhongban.Text);
                        cmd.Parameters.AddWithValue("@hesoluong", float.Parse(txtLuong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@chucvu", txtChucvu.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Them moi thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi tao moi " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtChucvu.Clear();
            txtHoten.Clear();
            txtManhanvien.Clear();
            cbxGioitinh.Items.Clear();
            cbxPhongban.Items.Clear();
            cbxTrangthai.Items.Clear();
            dtpNgaysinh.Value = DateTime.Today;
           
        }

        private SqlConnection connectDB()
        {
            String strCon = "Server=DESKTOP-E43PI42\\MSSQLSERVER2017;Database=WF_QL_nhanvien;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(strCon);
            return con;
        }
    }
}
