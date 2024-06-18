using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucThuan
{
    public class ListDepartment
    {
        private List<Department> departments;

        public ListDepartment()
        {
            departments = new List<Department>();
            departments.Add(new Department("Phong hanh chinh"));
            departments.Add(new Department("Phong ky thuat"));
            departments.Add(new Department("Phong ke toan"));
            departments.Add(new Department("Ban giam doc"));
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public void AddDepartment(string departmentName)
        {
            departments.Add(new Department(departmentName));
        }
        public void RemoveDepartment(Department department)
        {
            departments.Remove(department);
        }
    }

}
