using System;

namespace Simulators {

	public class Character {

		private int code;

		public Character () {
		}

		public override int GetHashCode () {
			return code.GetHashCode ();
		}

		public override bool Equals (object obj) {
			return ((obj != null && obj is Character && this.code == ((Character)obj).code) || base.Equals (obj));
		}

		public override string ToString () {
			if (code < 0x00) {
				return "<empty>";
			} else {
				return ((char)code).ToString ();
			}
		}

	}
}

