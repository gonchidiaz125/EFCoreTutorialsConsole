﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorialsConsoleGonchi.Entities
{
	public class Student
	{
		public int StudentId { get; set; }	

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int GradeId { get; set; }

		public Grade Grade { get; set; }
	}
}
