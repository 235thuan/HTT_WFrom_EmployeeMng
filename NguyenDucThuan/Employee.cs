using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucThuan
{
    public class Employee
    {
        // Private fields
        private string hoVaTen;
        private DateTime ngaySinh;
        private int maNV;
        private string gioiTinh;
        private string diaChi;
        private string email;
        private string diDong;
        private string vanHoa;
        private string chuyenMon;
        private string chucVu;
        private decimal luong;
        private string phongBan;
        private string trangThai;
        private decimal phuCap;
        private string hopdong;

        // Public properties
        public string HoVaTen
        {
            get { return hoVaTen; }
            set { hoVaTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string DiDong
        {
            get { return diDong; }
            set { diDong = value; }
        }

        public string VanHoa
        {
            get { return vanHoa; }
            set { vanHoa = value; }
        }

        public string ChuyenMon
        {
            get { return chuyenMon; }
            set { chuyenMon = value; }
        }

        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }

        public string TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string HopDong
        {
            get { return hopdong; }
            set { hopdong = value; }
        }

     

        public Employee()
        {

        }
        public Employee(string hoVaTen, DateTime ngaySinh, string diaChi, string email, string gioiTinh, string diDong,
                    string vanHoa, string chuyenMon, int maNV, string chucVu, string phongBan)
        {
            this.hoVaTen = hoVaTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.email = email;
            this.gioiTinh = gioiTinh;
            this.diDong = diDong;
            this.vanHoa = vanHoa;
            this.chuyenMon = chuyenMon;
            this.maNV = maNV;
            this.chucVu = chucVu;
            this.phongBan = phongBan;
        }

        public Employee(int maNv,string hoVaTen, DateTime ngaySinh, string gioiTinh, int maNV, string phongBan, string chucVu, string trangThai)
        {
            this.maNV= maNv;
            this.hoVaTen = hoVaTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.phongBan = phongBan;
            this.chucVu = chucVu;
            this.trangThai = trangThai;
        }
        public Employee(string hoVaTen, DateTime ngaySinh, string gioiTinh, int maNV, string phongBan, string chucVu, string trangThai)
        {
            this.hoVaTen = hoVaTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.phongBan = phongBan;
            this.chucVu = chucVu;
            this.trangThai = trangThai;
        }
    }
}