﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucThuan
{
    public class User
    {
        private string typeOfAccount { get; set; }
        private string userName { get; set; }
        private string password { get; set; }

        public string Username
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string TypeOfAccount
        {
            get { return typeOfAccount; }
            set { typeOfAccount = value; }
        }

        public User(string username, string password)
        {
            this.userName = username;
            this.password = password;
        }
        public User(string username, string password,string typeOfAccount)
        {
            this.userName = username;
            this.password = password;
            this.typeOfAccount = typeOfAccount;
        }
        public User()
        {

        }
    }
}
