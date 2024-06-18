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
        public List<User> GetUsers()
        {
            return listUserA;
        }
        public void CreateUser(string username, string password)
        {
            User newUser = new User(username, password);
            listUserA.Add(newUser);
            Console.WriteLine($"User '{username}' created successfully.");
        }
        public void CreateUserWithType(string username, string password,string typeOfAccount)
        {
            User newUser = new User(username, password,typeOfAccount);
            listUserA.Add(newUser);
            Console.WriteLine($"User '{username}' created successfully.");
        }

        public void UpdatePassword(string username, string newPassword)
        {
            User userToUpdate = FindUserByUsername(username);
            if (userToUpdate != null)
            {
                userToUpdate.Password = newPassword;
                Console.WriteLine($"Password updated for user '{username}'.");
            }
            else
            {
                Console.WriteLine($"User '{username}' not found.");
            }
        }
        public void UpdatePasswordWithType(string username, string newPassword,string newTypeOfAccount)
        {
            User userToUpdate = FindUserByUsername(username);
            if (userToUpdate != null)
            {
                userToUpdate.Password = newPassword;
                userToUpdate.TypeOfAccount = newTypeOfAccount;
                Console.WriteLine($"updated for user '{username}'.");
           
            }
            else
            {
                Console.WriteLine($"User '{username}' not found.");
            }
        }


        // Method to delete a user
        public void DeleteUser(string username)
        {
            User userToDelete = FindUserByUsername(username);
            if (userToDelete != null)
            {
                listUserA.Remove(userToDelete);
                Console.WriteLine($"User '{username}' deleted successfully.");
            }
            else
            {
                Console.WriteLine($"User '{username}' not found.");
            }
        }
        private User FindUserByUsername(string username)
        {
            return listUserA.Find(u => u.Username == username);
        }
    }
}
