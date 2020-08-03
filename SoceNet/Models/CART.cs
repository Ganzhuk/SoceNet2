using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoceNet.Models
{
    public class CART
    {
        public int CARTID { get; set; }
        public string CART_NAME { get; set; }
        public CART(int CARTID_, string CART_NAME_)
        {
            this.CARTID = CARTID_;
            this.CART_NAME = CART_NAME_;
        }
    }
}