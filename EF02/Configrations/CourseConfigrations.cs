using EF02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configrations
{
    internal class CourseConfigrations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses", "dbo");
            builder.HasKey(e => e.CId);
            builder.HasOne(e => e.Topic).WithMany(e => e.Courses);
            builder.Property(e => e.CId).UseIdentityColumn(10, 10);

        }
    }
}
