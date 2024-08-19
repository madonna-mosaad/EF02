using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    [Table("Stud_Course", Schema = "dbo")]
    internal class Stud_Course
    {
        [Key]
        public int Stud_Id { get; set; }
        public int? Course_Id { get; set; }
        public double Grade { get; set; }
    }
}
