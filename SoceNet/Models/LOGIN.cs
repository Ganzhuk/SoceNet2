using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoceNet.Models
{
    public class LOGIN
    {
        public int LOGINID { get; set; }
        public string LOGIN_NAME { get; set; }
        public LOGIN() { }
        public LOGIN(int LOGINID_, string LOGIN_NAME_)
        {
            this.LOGINID = LOGINID_;
            this.LOGIN_NAME = LOGIN_NAME_;
        }
    }
}