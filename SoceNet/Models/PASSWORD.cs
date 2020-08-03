using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoceNet.Models
{
    public class PASSWORD
    {
        public int PASSWORDID { get; set; }
        public string PASS_CODE { get; set; }
        public PASSWORD() { }
        public PASSWORD(int PASSWORDID_, string PASS_CODE_)
        {
            this.PASSWORDID = PASSWORDID_;
            this.PASS_CODE = PASS_CODE_;
        }
    }
}