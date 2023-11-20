using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminary.Model
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        //שנות ותק
        public int Seniority { get; set; }
        public int Age { get; set; }

        public int? Subjectid { get; set; }
        [ForeignKey(nameof(Subjectid))]
        public Subject TeacherOfSubjec { get; set; }
    }
}
