﻿using EF02.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Configrations
{
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "dbo");
            builder.HasKey(e => e.DId);
            builder.HasOne(e => e.Instructor);
            builder.Property(e => e.DId).UseIdentityColumn(10, 10);

        }
    }
}
