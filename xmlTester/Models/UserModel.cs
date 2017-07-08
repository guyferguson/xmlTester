using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlTester.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string GUID { get; set; }
        public DateTime DateAdded { get; set; }


        public Active Active { get; set; }
    }
}