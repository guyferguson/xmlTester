using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace xmlTester.Models
{
    [XmlRoot("return")]
    public class returns : List<form>
    {

        [XmlAttribute("entityName")]
        public string entityName { get; set; }
        [XmlAttribute("entity")]    //ABN
        public string entity { get; set; } 
    }
 
}