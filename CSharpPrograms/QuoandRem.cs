using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
	public class QuoandRem
	{
		public static void FindQuoandRem()
		{
			int a,b,q,r;                            //static variables

			Console.Write("Enter first number: ");
	        a = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			b = Convert.ToInt32(Console.ReadLine());

			q = a / b;
			r = a % b;

			Console.WriteLine("Quotient is:" + q);
			Console.WriteLine("Remainder is:" + r);
		}
	}
}
