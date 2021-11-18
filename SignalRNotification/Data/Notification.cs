using System;

namespace SignalRNotification.Data
{
    public class Notification
    {
        public int MsgId { get; set; } = 0;
        public string SenderName { get; set; } = "";
        public string ReciverName { get; set; } = "";
        public string MsgTitle { get; set; } = "";
        public string MsgBody { get; set; } = "";
        public DateTime MsgDate { get; set; } = DateTime.Now;
        public string MsgDateSt => this.MsgDate.ToString("dd-MMM-yyyy");


    }
}