using System.Collections.Generic;

namespace Simulators {
	public class ParseContext<TEdge> {

		private readonly Dictionary<string,State<TEdge>> received = new Dictionary<string, State<TEdge>> ();

		public ParseContext () {
		}

		public State<TEdge> GetState (string name) {
			State<TEdge> state;
			if (!this.received.TryGetValue (name, out state)) {
				state = new State<TEdge> (name);
				this.received.Add (name, state);
			}
			return state;
		}

	}
}