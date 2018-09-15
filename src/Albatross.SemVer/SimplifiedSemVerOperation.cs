using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Albatross.SemVer {
	public class SimplifiedSemVerOperation : ISemanticVersionOperation {
		const string DefaultLabel = "alpha";


		public bool IsSupported(SematicVersion semver) {
			return true;
		}

		public void Next() {
			throw new NotImplementedException();
		}

		public void NextMajor() {
			throw new NotImplementedException();
		}

		public void NextMinor() {
			throw new NotImplementedException();
		}

		public void NextPatch() {
			throw new NotImplementedException();
		}

		public void NextRelease() {
			throw new NotImplementedException();
		}
	}
}
