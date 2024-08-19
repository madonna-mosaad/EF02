using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    [Table("Course_Inst", Schema = "dbo")]
    internal class Course_Inst
    {
        [Key]
        public int Course_Id { get; set; }
        public int? Ins_Id { get; set; }
        public int Evaluate { get; set; }
    }
}
