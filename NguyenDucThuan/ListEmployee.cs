using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucThuan
{
    public class ListEmployee
    {
        private List<Employee> listemploy;
        public List<Employee> Listempoy
        {
            get
            {
                return listemploy;
            }
            set
            {
                listemploy = value;
            }
        }
        private static ListEmployee instance;


        public static ListEmployee Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListEmployee();
                return instance;

            }
            set { instance = value; }

        }
        private ListEmployee()
        {
            listemploy = new List<Employee>();
            listemploy.Add(new Employee(1,"Le Vui", new DateTime(2005, 10, 20), "Nu", 1, "Phong hanh chinh", "nhân viên", "Đang làm việc"));
            listemploy.Add(new Employee(2,"Hoang Anh", new DateTime(2004, 08, 20), "Nam", 2, "Phong ky thuat", "nhân viên", "Đang làm việc"));
            listemploy.Add(new Employee(3,"Nguyen van Hung", new DateTime(2000, 02, 10), "Nam", 3, "Ban giam doc", "Giam doc dieu hanh", "Đang làm việc"));
            listemploy.Add(new Employee(4,"Nguyen Thi Cuc", new DateTime(1995, 02, 04), "Nu", 4, "Phong ke toan", "Truong phong", "Đang làm việc"));
            listemploy.Add(new Employee(5,"Hai Anh", new DateTime(2005, 10, 20), "Nu", 5, "Phong hanh chinh", "nhân viên", "Đang làm việc"));
        }
    }
}
