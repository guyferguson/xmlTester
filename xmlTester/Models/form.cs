using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xmlTester.Models
{

    public class formOwner
    {
        public string entityName { get; set; }
        public string name { get; set; }
        public long entity { get; set; }
        public DateTime period{ get; set; }

    }
    public class form
    {
        public string code { get; set; }
        public string name { get; set; }
        public List<formItems> items { get; set; }

    }

    public class formItems
    {
        public string code { get; set; }
        public string type { get; set; }
        public int value { get; set; }

    }
}