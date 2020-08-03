using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoceNet.Models
{
    public class MESSAGE
    {
        public int MESSAGEID { get; set; }
        public int USER_ID { get; set; }
        public int CART_ID { get; set; }
        public MESSAGE() { }
        public MESSAGE(int MESSAGEID_, int USER_ID_, int CART_ID_)
        {
            this.MESSAGEID = MESSAGEID_;
            this.USER_ID = USER_ID_;
            this.CART_ID = CART_ID_;
        }
    }
}