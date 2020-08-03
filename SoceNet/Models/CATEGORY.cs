using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoceNet.Models
{
    public class CATEGORY
    {
        public int CATEGORYID { get; set; }
        public string CATEGORY_NAME { get; set; }
        public CATEGORY() { }
        public CATEGORY(int CATEGORYID_, string CATEGORY_NAME_)
        {
            this.CATEGORYID = CATEGORYID_;
            this.CATEGORY_NAME = CATEGORY_NAME_;
        }
    }
}