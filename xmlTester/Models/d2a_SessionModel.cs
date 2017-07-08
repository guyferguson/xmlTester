using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlTester.Models
{
    public class d2a_SessionModel
    {
        
        [ForeignKey("ID")]
        public virtual UserModel User { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }   //Session ID

        public DateTime logon { get; set; }


    }
}