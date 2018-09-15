using System;
using System.Text.RegularExpressions;

namespace Albatross.SemVer.Core {
	
	public class SematicVersion {
		const string DefaultLabel = "alpha";
		const string Pattern = @"^(\d+)\.(\d+)\.(\d+)(-([a-zA-Z_]+)(\.(\d+))?)?$";
		static readonly Regex regex = new Regex(Pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);

		public int Major { get; set; }
		public int Minor { get; set; }
		public int Patch { get; set; }
		public string Label { get; set; }
		public int Revision { get; set; }

		public SematicVersion(string version) {
			Parse(version);

		}
		public SematicVersion() { }

		public override string ToString() {
			if (IsRelease) {
				return $"{Major}.{Minor}.{Patch}";
			} else if(Revision == 0) {
				return $"{Major}.{Minor}.{Patch}-{Label}";
			} else {
				return $"{Major}.{Minor}.{Patch}-{Label}.{Revision}";
			}
		}

		public bool IsRelease { get { return string.IsNullOrEmpty(Label); } }

		public void BumpMajor(string label = null) {
			Major++;
			Minor = 0;
			Patch = 0;
			Revision = 0;
		}

		public void Parse(string version) {
			Match match = regex.Match(version);
			if (match.Success) {
				Major =int.Parse(match.Groups[1].Value);
				Minor = int.Parse(match.Groups[2].Value);
				Patch = int.Parse(match.Groups[3].Value);
				if (match.Groups[5].Success) {
					Label = match.Groups[5].Value;
				}
				if (match.Groups[7].Success) {
					Revision = int.Parse(match.Groups[7].Value);
				}
			} else {
				throw new Exception($"Invalid or NotSupported Version Format: {version}");
			}
		}
	}
}
