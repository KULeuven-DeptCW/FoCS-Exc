using System;

namespace Simulators {

	public class TM {

		public State<TMEdge> BeginState {
			get;
			private set;
		}

		public TM (State<TMEdge> beginState) {
			this.BeginState = beginState;
		}

		public static TM Parse () {

		}

	}
}

