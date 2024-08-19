using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    [Table("Courses",Schema ="dbo")]
    internal class Course
    {
        [Key]
        public int CId { get; set; }
        [Required]
        [Column(TypeName="varchar")]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        [InverseProperty("Courses")]
        public Topic? Topic { get; set; }
        [ForeignKey("Topic")]
        public int? Top_Id { get; set; }
    }
}
