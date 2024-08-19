using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    [Table("Students", Schema = "dbo")]
    internal class Student
    {
        [Key]
        public int SId { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(18,50)]
        public int Age { get; set; }
        [InverseProperty("Students")]
        public Department? Department { get; set; }
        [ForeignKey("Department")]
        public int? Dep_Id { get; set; }

    }
}
