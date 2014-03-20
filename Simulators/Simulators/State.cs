using System.Text;
using System.Collections.Generic;

namespace Simulators {

	public class State<TEdge> {

		public string Name {
			get;
			set;
		}
		private readonly Dictionary<Character,TEdge> edges;

		public State () {
		}

		public override string ToString () {
			StringBuilder sb = new StringBuilder ();
			sb.AppendFormat ("State {0}", this.Name);
			sb.AppendLine ();
			foreach (KeyValuePair<Character,TEdge> edge in edges) {
				sb.AppendFormat ("\t{0}/{1}", edge.Key, edge.Value);
				sb.AppendLine ();
			}
			return sb.ToString ();
		}
	}
}

