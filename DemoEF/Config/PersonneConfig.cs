using DemoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Config
{
	public class PersonneConfig : IEntityTypeConfiguration<Personne>
	{
		public void Configure(EntityTypeBuilder<Personne> builder)
		{
			//Spécifie le nom de la table
			builder.ToTable<Personne>(t=>t.HasCheckConstraint("CK_Email", "Email LIKE '___%@___%.___'"));
			//Définir ma clé primaire
			builder.HasKey(x=> x.Id);
			//Auto-increment
			builder.Property(p => p.Id).ValueGeneratedOnAdd();

			//Configurer les colonnes
			builder.Property(p=>p.Name).IsRequired();
			builder.Property(p => p.Name).HasColumnName("LastName").HasMaxLength(175);
			builder.Property(p => p.FirstName).HasMaxLength(200);
			builder.Property(p => p.Email).IsRequired().HasMaxLength(320);

			builder.HasAlternateKey(p => p.Email).HasName("UK_Email");

			//builder.HasCheckConstraint("CK_Email", "Email LIKE '___%@___%.___'").HasIndex(p=>p.Email).IsUnique();
		}
	}
}
