using System.Text;
using System.Collections.Generic;

namespace Simulators {

	public class State<TEdge> {

		public string Name {
			get;
			set;
		}

		public bool Accepting {
			get;
			set;
		}

		public TEdge this [Character c] {
			get {
				TEdge res = default(TEdge);
				this.edges.TryGetValue (c, out res);
				return res;
			}
		}

		private readonly Dictionary<Character,TEdge> edges = new Dictionary<Character, TEdge> ();

		public State (string name, bool accepting = false) {
			this.Name = name;
			this.Accepting = accepting;
		}

		public void AddEdge (Character c, TEdge edge) {
			this.edges.Add (c, edge);
		}

		public override string ToString () {
			StringBuilder sb = new StringBuilder ();
			sb.AppendFormat ("State");
			if (this.Accepting) {
				sb.Append ("!");
			}
			sb.Append (' ');
			sb.Append (this.Name);
			sb.AppendLine ();
			foreach (KeyValuePair<Character,TEdge> edge in edges) {
				sb.AppendFormat ("\t{0}/{1}", edge.Key, edge.Value);
				sb.AppendLine ();
			}
			return sb.ToString ();
		}
	}
}

