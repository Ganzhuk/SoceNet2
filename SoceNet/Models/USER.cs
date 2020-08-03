using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoceNet.Models
{
    public class USER
    {
        public int USERID { get; set; }
        public string USER_FNAME { get; set; }
        public string USER_LNAME { get; set; }
        public string USER_SITY { get; set; }
        public DateTime USER_BIRTHDAY { get; set; }
        public bool USER_STATUS { get; set; }
        public  int LOGIN_ID { get; set; }
        public int PASSWORD_ID { get; set; }
        public USER() { }
        public USER(int USERID_, string USER_FNAME_, string USER_LNAME_, string USER_SITY_, DateTime USER_BIRTHDAY_, bool USER_STATUS_, int LOGIN_ID_, int PASSWORD_ID_)
        {
            this.USERID = USERID_;
            this.USER_FNAME = USER_FNAME_;
            this.USER_LNAME = USER_LNAME_;
            this.USER_SITY = USER_SITY_;
            this.USER_BIRTHDAY = USER_BIRTHDAY_;
            this.USER_STATUS = USER_STATUS_;
            this.LOGIN_ID = LOGIN_ID_;
            this.PASSWORD_ID = PASSWORD_ID_;
        }
    }
}