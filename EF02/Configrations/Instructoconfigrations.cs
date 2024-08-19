using EF02.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configrations
{
    internal class Instructoconfigrations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors", "dbo");
            builder.HasKey(e => e.InsId);
            builder.HasOne(e => e.Department).WithMany(e => e.Instructors);
            builder.Property(e => e.InsId).UseIdentityColumn(10, 10);

        }
    }
}
