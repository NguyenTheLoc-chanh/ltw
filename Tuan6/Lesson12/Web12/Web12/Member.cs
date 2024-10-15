using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web12
{
    public class Member
    {
        private string nickName;
        private string color;

        public Member(string NickName, string Color)
        {
            this.nickName = NickName;
            this.color = Color;
        }

        public Member()
        {

        }

        public string sNickName { get => nickName; set => nickName = value; }
        public string sColor { get => color; set => color = value; }
    }
}