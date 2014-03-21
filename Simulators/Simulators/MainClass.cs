using System;
using System.IO;

namespace Simulators {

	public class MainClass {

		public static int Main (params string[] args) {
			string fl = "test.tm";
			if (args.Length > 0x00) {
				fl = args [0x00];
			}
			using (FileStream fs = File.OpenRead (fl)) {
				using (TextReader tr = new StreamReader(fs)) {
					TM tm = TM.Parse (tr);
					string inp = "";
					if (args.Length > 0x01) {
						inp = args [0x01];
					}
					TMSimulation tmsim = new TMSimulation (tm, inp);
					Console.WriteLine (tmsim);
					while (Console.In.Read() != 0x00) {
						tmsim.Step ();
						Console.WriteLine (tmsim);
					}
				}
			}
			return 0x00;
		}

	}

}