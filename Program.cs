using System;
using Task;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Student student = new Student("Ismayil", "Ibrahimzade", "BP217", 64);
			student.GetInfo();
			student.CheckGraduation();
			student.GetDiplomDegree();
		}

		
	}
}
