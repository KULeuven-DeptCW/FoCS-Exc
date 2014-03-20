using System.Linq;
using System.Collections.Generic;

namespace Simulators {

	public class TMSimulation {

		public readonly Stack<Character> LStack = new Stack<Character> ();
		public readonly Stack<Character> RStack = new Stack<Character> ();
		public State<TMEdge> CurrentState;

		public TMSimulation (IEnumerable<Character> chars) {
			foreach (Character c in chars.Reverse()) {
				RStack.Push (c);
			}
			this.Fix ();
		}

		public Character Current {
			get {
				return this.RStack.Peek ();
			}
			set {
				this.RStack.Pop ();
				this.RStack.Push (value);
			}
		}

		public void Fix () {
			if (LStack.Count <= 0x00) {
				LStack.Push (Character.Empty);
			}
			if (RStack.Count <= 0x00) {
				RStack.Push (Character.Empty);
			}
		}

		public void Step () {
			TMEdge edge = this.CurrentState [this.Current];
			if (edge == null) {
				this.CurrentState = null;
			} else {

			}
		}

		public void MoveHead (TMDirection dir) {
			Stack<Character> l = LStack, r = RStack;
			switch (dir) {
				case TMDirection.Left:
					Stack<Character> t = l;
					l = r;
					r = t;
					goto case TMDirection.Right;
				case TMDirection.Right:
					l.Push (r.Pop ());
					this.Fix ();
					break;
			}
		}

	}

}

