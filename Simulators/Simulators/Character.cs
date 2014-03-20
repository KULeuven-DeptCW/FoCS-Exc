using System;

namespace Simulators {

	public struct Character {

		public static readonly Character Empty = new Character (-0x01);

		private readonly int code;

		public Character (int code) {
			this.code = code;
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

