using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xmlTester.Models
{
    public class d2a_UserInfoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("ID")]
        public virtual UserModel User { get; set; }

        public virtual ICollection<FundModel> Funds { get; set; }
        public virtual ICollection<d2a_ReturnSetModel> ReturnSets { get; set; }
    }
}