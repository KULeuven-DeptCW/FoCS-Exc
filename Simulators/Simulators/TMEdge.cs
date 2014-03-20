using System;

namespace Simulators {
	public class TMEdge : Tuple<State<TMEdge>,Character,TMDirection> {

		public TMEdge (State<TMEdge> state, Character chr, TMDirection dir) : base(state,chr,dir) {
		}

		public override string ToString () {
			return string.Format ("{0}/{1}/{2}", this.Item1.Name, this.Item2, this.Item3.ToString () [0x00]);
		}

	}
}

