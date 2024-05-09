using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorialsConsoleGonchi.Entities
{
	public class Grade
	{
		public int GradeID { get; set; }
		public string GradeName { get; set; }

		public IList<Student> Students { get; set; }
	}
}
