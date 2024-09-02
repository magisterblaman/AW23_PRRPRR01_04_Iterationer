using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_04_Iterationer {
	internal class Program {
		static void Main(string[] args) {

			int myInt = 43;

			bool run = true;

			while (run) {
				Console.WriteLine("Vill du köra en gång till?");
				string answer = Console.ReadLine().ToLower();

				if (answer == "nej") {
					run = false;
				}
			}

		}
	}
}
