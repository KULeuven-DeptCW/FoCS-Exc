using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Simulators {

	public class TM {

		private static readonly Regex stateRegex = new Regex (@"^State ([^!]+)(!?)$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
		private static readonly Regex edgeRegex = new Regex (@"(.)/([^!]+)/(.)/([LRS])$", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

		public State<TMEdge> BeginState {
			get;
			private set;
		}

		public TM (State<TMEdge> beginState) {
			this.BeginState = beginState;
		}

		public static TM Parse (TextReader tr) {
			ParseContext<TMEdge> pc = new ParseContext<TMEdge> ();
			State<TMEdge> currentState = null, targetState, initState = null;
			string line = tr.ReadLine ();
			Character ca, cb;
			Match m;
			TMDirection dir;
			while (line != null) {
				m = stateRegex.Match (line);
				if (m.Success) {
					if (currentState == null) {
						initState = pc.GetState (m.Groups [0x01].Value);
						currentState = initState;
					} else {
						currentState = pc.GetState (m.Groups [0x01].Value);
					}
					currentState.Accepting = m.Groups [0x02].Value == "!";
				} else if (currentState != null) {
					m = edgeRegex.Match (line);
					if (m.Success) {
						ca = Character.Parse (m.Groups [0x01].Value [0x00]);
						targetState = pc.GetState (m.Groups [0x02].Value);
						cb = Character.Parse (m.Groups [0x03].Value [0x00]);
						dir = TMDirection.Stay;
						char c = m.Groups [0x04].Value [0x00];
						if (c == 'L') {
							dir = TMDirection.Left;
						} else if (c == 'R') {
							dir = TMDirection.Right;
						}
						currentState.AddEdge (ca, new TMEdge (targetState, cb, dir));
					}
				}
				line = tr.ReadLine ();
			}
			return new TM (initState);
		}

	}
}