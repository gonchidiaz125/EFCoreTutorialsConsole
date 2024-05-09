// See https://aka.ms/new-console-template for more information
using EFCoreTutorialsConsoleGonchi.Entities;
using EFCoreTutorialsConsoleGonchi.Repositories;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");


// CargarAlgoEnLaBaseDeDatos();

SoloMostrarEstudiantes();


void CargarAlgoEnLaBaseDeDatos()
{
	using (var context = new SchoolDbContext())
	{
		// creates db if not exists 
		// context.Database.EnsureCreated();
		
		var grade = new Grade() { GradeName = "Tercer año" };

		var student1 = new Student() { FirstName = "Paulina", LastName = "Delmastro", Grade = grade };
		var student2 = new Student() { FirstName = "Paulina", LastName = "Vicente", Grade = grade };
		
		context.Students.Add(student1);
		context.Students.Add(student2);

		context.SaveChanges();

		foreach (var s in context.Students)
		{
			Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}");
		}

		Console.ReadLine();
	}
}

void SoloMostrarEstudiantes()
{
	using (var context = new SchoolDbContext())
	{
		Console.WriteLine("Estudiantes: ");

		//var provincia = dbContext.Provincias
		//	.Include(p => p.Departamentos)
		//	.FirstOrDefault(p => p.Nombre == nombre);

		var students = context.Students
			.Include(s => s.Grade);

		foreach (var s in students)
		{
			Console.WriteLine($"First Name: {s.FirstName}, Last Name: {s.LastName}, Grade Id: {s.GradeId}, Grade Name: {s.Grade.GradeName}");
		}

		Console.ReadLine();
	}
}