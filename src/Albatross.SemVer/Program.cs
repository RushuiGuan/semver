using System;
using System.Collections.Generic;
using System.Text;

namespace Albatross.SemVer
{
    public class Program
    {
		public static void Main() {
			var sem = new SematicVersion();
			string[] data = new string[] {
				"1.2.3",
				"1.2.3-alpha",
				"1.2.3-alpha.0",
			};
			foreach (string line in data) {
				sem.Parse(line);
				Console.WriteLine(sem);
			}
		}
    }
}
