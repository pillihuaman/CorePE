using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPICIp.BackEnd
{
    public class Feedback
    {

        public string Id { get; set; }
        public string EmailId { get; set; }
        public string Comment { get; set; }
        public string PageUrl { get; set; }
        public byte[] Attachment { get; set; }
    }
}