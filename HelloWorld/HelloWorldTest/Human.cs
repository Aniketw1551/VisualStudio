using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
/// <summary>
/// creating Human blueprint
/// </summary>
 public class Human
{
	/// <summary>
	/// Characteristics of human being
	/// </summary>
	string name = "Rahul";
	double age = 27;

	/// <summary>
	/// Actions
	/// </summary>
	public void Run()
	{
		//Human Actions
		Console.WriteLine("Running,Walking,crawling");
		Console.ReadLine();

	}
}
}