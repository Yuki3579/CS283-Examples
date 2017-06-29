using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Student aStudent = new Student()
			{
				Name = "林姿君",
				Phone = "0910123456",
				Address = "台大資工"
			};
			Console.WriteLine(aStudent.Name);
			Console.WriteLine(aStudent.Address);
		}
	}
}