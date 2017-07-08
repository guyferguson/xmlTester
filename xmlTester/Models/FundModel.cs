using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlTester.Models
{
    public enum Active
    {
        Y, N
    }
    public enum UserType
    {
        ViewOnly, Administrator, AdministratorPlus, SecurePayroll
    }

    public class FundModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(6)]
        public string FundCode { get; set; }

        [Display(Name = "Fund Name")]
        public string FullName { get; set; }

        public long ABN { get; set; }

        [Display(Name = "RSE Licensee")]
        public int FundID { get; set; }
        public DateTime DateAdded { get; set; }
        public Active Active { get; set; }

    }
}