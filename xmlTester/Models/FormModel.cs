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
        public string entity { get; set; }
        public DateTime period{ get; set; }

    }

    public class csReturn
    {
        public List<FormModel> fms { get; set; }
        public formOwner fo { get; set; }

    }
    public class FormModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }                                     //  0
        public string code { get; set; }                                // 'SRF_320_0'
        public string name { get; set; }                                // 'Statement of Financial Position'
        public List<formItems> items { get; set; }          //  <apra:fundBalance.notional, 100.00>


    }

    public class formItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }                                     // 0
        public IDictionary<string, int> codeVals { get; set; }       // <'BSE100003'.477411>
        public string type { get; set; }                                // 'apra:fundBalance.notional'
        public string data_type { get; set; }                           // 'MONETARY'

    }
}