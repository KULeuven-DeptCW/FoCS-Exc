using System;

namespace Simulators {

	public class TM {

		private readonly State<TMEdge> beginState;

		public TM (State<TMEdge> beginState) {
			this.beginState = beginState;
		}

	}
}

