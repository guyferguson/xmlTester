using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlTester.Models
{

    public class formOwner
    {
        public string entityName { get; set; }
        public string name { get; set; }
        public long entity { get; set; }
        public DateTime period{ get; set; }

    }
    public class FormModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public List<formItems> items { get; set; }

    }

    public class formItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public int value { get; set; }

    }
}