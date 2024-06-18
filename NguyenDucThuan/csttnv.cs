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
    public partial class frmCsttnv : Form
    {
        public frmCsttnv()
        {
            InitializeComponent();
        }
        void LoadInfor()
        {
            txtHoten.Text = Const.newEmploy.HoVaTen;
            cbxGioitinh.Text = Const.newEmploy.GioiTinh;
            dtpNgaysinh.Value = Const.newEmploy.NgaySinh;
            txtManhanvien.Text = Const.newEmploy.MaNV.ToString();
            cbxPhongban.Text = Const.newEmploy.PhongBan;
            txtChucvu.Text = Const.newEmploy.ChucVu;
            cbxTrangthai.Text = Const.newEmploy.TrangThai;
        }
        private void cbxGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmCsttnv_Load(object sender, EventArgs e)
        {
            cbxGioitinh.DataSource = Const.listSex;
            cbxPhongban.DataSource = Const.listDepartment;
            cbxTrangthai.DataSource = Const.listTrangthai;
            LoadInfor();
        }
    }
}
