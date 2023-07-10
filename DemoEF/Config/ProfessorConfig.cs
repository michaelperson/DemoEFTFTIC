using DemoEF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Config
{
	public class ProfessorConfig : IEntityTypeConfiguration<Professor>
	{
		public void Configure(EntityTypeBuilder<Professor> builder)
		{

			builder.ToTable<Professor>(t => t.HasCheckConstraint("CK_Email", "Professor_Email LIKE '___%@___%.___'"));

			builder.HasKey(k => k.Professor_ID).HasName("PK_Prof");
			builder.Property(p => p.Professor_ID).ValueGeneratedOnAdd();
			 
			builder.Property(p => p.Professor_Name).IsRequired().HasMaxLength(30);
			builder.Property(p => p.Professor_Surname).IsRequired().HasMaxLength(150);
			builder.Property(p => p.Professor_Email).IsRequired().HasMaxLength(320);
			builder.Property(p => p.Section_ID).IsRequired();
			builder.Property(p => p.Professor_Office).IsRequired();

			//Relations
			builder.HasMany(prof => prof.Courses)
				.WithOne(cours => cours.Professor);
		}


	}
}
