using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			WelcomeUser();
			string name = GetUserName();
			SayHello(name);
			_ = Console.ReadLine();
		}

		private static void WelcomeUser()
		{
			Console.WriteLine("Welcome to Foundation in C#!");
		}

		private static string GetUserName()
		{
			Console.Write("What is your first name: ");
			string output = Console.ReadLine();
			return output;
		}

		private static void SayHello(string firstName)
		{
			Console.WriteLine($"Hello {firstName}!");
		}
	}
}
