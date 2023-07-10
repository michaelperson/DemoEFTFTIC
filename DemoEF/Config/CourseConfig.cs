using DemoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Config
{
	public class CourseConfig : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasKey(k => k.Course_ID).HasName("PK_Course");
			builder.Property(p => p.Course_ID).HasMaxLength(8);
			
			builder.Property(p=>p.Course_Name).IsRequired().HasMaxLength(200);
			builder.Property(p=>p.Course_Ects).HasPrecision(3,1).IsRequired().HasColumnType("decimal");
			builder.Property(p => p.Professor_ID).IsRequired();

			//Relation
			builder.HasOne(m => m.Professor)
				.WithMany(p => p.Courses)
				.HasForeignKey(c => c.Professor_ID);
				
		}

		 
	}
}
