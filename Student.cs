using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Task
{
	public class Student
	{
		public string Name;
		public string Surname;
		public string GroupName;
		public int Point;
		public bool IsGraduated;


		public Student(string name, string surname, string groupName, int point)
		{
			Name = name;
			Surname = surname;
			GroupName = groupName;
			Point = point;
			
		}


		public void GetInfo()
		{
			Console.WriteLine($"Name - {Name}  ");
            Console.WriteLine($"Surname - { Surname}");
            Console.WriteLine($"Group Name - { GroupName}");
            Console.WriteLine($"Point - { Point}" );
            
		}


		public void CheckGraduation()
		{
			if (Point>=65)
			{
				Console.WriteLine("Graduated");
			}
			else
			{
				Console.WriteLine("Not Graduated");
			}
		}
		public void GetDiplomDegree()
		{
			if (Point < 65)
			{
				Console.WriteLine("Not any diploma");
			}
			else if (Point >= 65 && Point < 80)
			{
				Console.WriteLine("Has an Ordinary Diploma");
			}
			else if (Point >= 80 && Point < 90)
			{
				Console.WriteLine("Has an Honor Diploma");
			}
			else if (Point >= 90)
			{
				Console.WriteLine("Has a High Honor Diploma");
			}
		}
	}



}
