using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulators {

	public class TMSimulation {

		public readonly Stack<Character> LStack = new Stack<Character> ();
		public readonly Stack<Character> RStack = new Stack<Character> ();
		public State<TMEdge> CurrentState;

		public TMSimulation (TM machine, IEnumerable<Character> chars) {
			this.CurrentState = machine.BeginState;
			foreach (Character c in chars.Reverse()) {
				RStack.Push (c);
			}
			this.Fix ();
		}

		public Character CurrentCharacter {
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
			TMEdge edge = this.CurrentState [this.CurrentCharacter];
			if (edge == null) {
				this.CurrentState = null;
			} else {
				this.CurrentCharacter = edge.WriteCharacter;
				this.MoveHead (edge.Direction);
				this.CurrentState = edge.TargetState;
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

		public override string ToString () {
			StringBuilder sb = new StringBuilder ();
			string sl = string.Join (" ", this.LStack.Reverse ());
			sb.Append (sl);
			sb.Append (' ');
			sb.Append (string.Join (" ", this.RStack));
			sb.AppendLine ();
			for (int i = sl.Length; i > 0x00; i--) {
				sb.Append (' ');
			}
			sb.Append (' ');
			if (this.CurrentState != null) {
				sb.Append (this.CurrentState.Name);
			} else {
				sb.Append ("<crash>");
			}
			return sb.ToString ();
		}

	}

}

