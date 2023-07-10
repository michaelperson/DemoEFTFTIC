using DemoEF.Config;
using DemoEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF
{
	public class ExempleContext :DbContext
	{

		/*Accesseur pour nos tables*/
		public DbSet<Personne> Personnes { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Professor> Professors { get; set; }

		/// <summary>
		/// C'est ici que je vais renseigner mes fichiers de configs pour mes entités/table
		/// </summary>
		/// <param name="modelBuilder">Représente l'objet global DB faisant le lien entre mon c# et mes tables</param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			//Ajout de la config pour la table personne
			modelBuilder.ApplyConfiguration<Personne>(new PersonneConfig());
			//Ajout de la config pour la table Course
			modelBuilder.ApplyConfiguration<Course>(new CourseConfig());
			//Ajout de la config pour la table Prof
			modelBuilder.ApplyConfiguration<Professor>(new ProfessorConfig());
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
		{
			//Quel base de données j'utilise : Type et la connectionstring
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SampleEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		}
	}
}
