using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web12
{
    public class MessSendInfo
    {
        private string nickName;
        private string color;
        private string message;
        private string timeStamp;

        public MessSendInfo(string nickName, string color, string message, string timeStamp)
        {
            this.nickName = nickName;
            this.color = color;
            this.message = message;
            this.timeStamp = timeStamp;
        }

        public MessSendInfo(string message, string timeStamp)
        {
            this.message = message;
            this.timeStamp = timeStamp;
        }

        public string snickName { get => nickName; set => nickName = value; }
        public string scolor { get => color; set => color = value; }
        public string smessage { get => message; set => message = value; }
        public string stimeStamp { get => timeStamp; set => timeStamp = value; }
    }
}