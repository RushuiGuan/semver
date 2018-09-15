using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Albatross.SemVer {

	public class SemVerOperation : ISemanticVersionOperation {
		public void Next(SematicVersion sematicVersion, string label = "alpha") {
			List<string> list = new List<string>();

			if (sematicVersion.PreRelease == null || sematicVersion.PreRelease.Count() == 0) {
				list.Add(label);
			} else {
				list.AddRange(sematicVersion.PreRelease);
				int version;
				if (int.TryParse(sematicVersion.PreRelease.Last(), out version)) {
					list[list.Count - 1] = Convert.ToString(version + 1);
				} else {
					list.Add("0");
				}
			}
			sematicVersion.PreRelease = list;
			sematicVersion.Validate();
		}

		public void NextMajor(SematicVersion sematicVersion, string label = "alpha") {
			sematicVersion.Major++;
			sematicVersion.Minor = 0;
			sematicVersion.Patch = 0;
			sematicVersion.PreRelease = new string[] { label };
			sematicVersion.Validate();
		}

		public void NextMinor(SematicVersion sematicVersion, string label = "alpha") {
			sematicVersion.Minor++;
			sematicVersion.Patch = 0;
			sematicVersion.PreRelease = new string[] { label };
			sematicVersion.Validate();
		}

		public void NextPatch(SematicVersion sematicVersion, string label = "alpha") {
			sematicVersion.Patch++;
			sematicVersion.PreRelease = new string[] { label };
			sematicVersion.Validate();
		}

		public void NextRelease(SematicVersion sematicVersion) {
			sematicVersion.PreRelease = null;
			if(sematicVersion.Major == 0) {
				sematicVersion.Major = 1;
			}
			sematicVersion.Validate();
		}
	}
}
