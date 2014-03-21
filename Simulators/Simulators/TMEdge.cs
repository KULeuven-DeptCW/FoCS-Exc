using System;

namespace Simulators {
	public class TMEdge : Tuple<State<TMEdge>,Character,TMDirection> {

		public State<TMEdge> TargetState {
			get {
				return this.Item1;
			}
		}

		public Character WriteCharacter {
			get {
				return this.Item2;
			}
		}

		public TMDirection Direction {
			get {
				return this.Item3;
			}
		}

		public TMEdge (State<TMEdge> state, Character chr, TMDirection dir) : base(state,chr,dir) {
		}

		public override string ToString () {
			return string.Format ("{0}/{1}/{2}", this.Item1.Name, this.Item2, this.Item3.ToString () [0x00]);
		}

	}
}

