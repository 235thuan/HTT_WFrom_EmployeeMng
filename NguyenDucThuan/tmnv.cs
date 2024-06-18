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
            string name=txtHoten.Text;
            int maNv = int.Parse(txtManhanvien.Text.Trim());

            DateTime birthday = dtpNgaysinh.Value;
            string sex = cbxGioitinh.Text;
            int employeeId = 0;
            if (txtManhanvien.Text !="")
            {
                 employeeId = Convert.ToInt32(txtManhanvien.Text);
            }
            string department = cbxPhongban.Text;
            string position = txtChucvu.Text;
            string status = cbxTrangthai.Text;
            Const.newEmploy = new Employee(maNv,name, birthday, sex, employeeId, department, position, status);
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
    }
}
