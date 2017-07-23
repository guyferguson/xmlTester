using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlTester.Models
{
    [XmlRoot("return")]
    public class d2a_ReturnSetModel : List<FormModel>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [XmlAttribute("entityName")]
        public string entityName { get; set; }

        [XmlAttribute("entity")]    //ABN
        public string entity { get; set; }

        public string FullName { get; internal set; }
    }
 
}