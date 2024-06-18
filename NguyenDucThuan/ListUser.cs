using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucThuan
{
    public class ListUser
    {
        private List<User> listUserA;
        private static ListUser instance;
        public List<User> ListUserA
        {
            get { return listUserA; }
            set { listUserA = value; }
        }
        public static ListUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ListUser();
                }
                return instance;
            }
            set { instance = value; }
        }

        public ListUser()
        {
            listUserA = new List<User>();
            listUserA.Add(new User("admin", "admin"));
        }
    }
}
