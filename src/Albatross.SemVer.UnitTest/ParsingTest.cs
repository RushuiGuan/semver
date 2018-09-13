using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Albatross.SemVer.UnitTest
{
	[TestFixture]
    public class ParsingTest
    {
		[TestCase("1.2.3", ExpectedResult ="1.2.3")]
		[TestCase("1.2.3-beta", ExpectedResult = "1.2.3-beta")]
		[TestCase("1.2.3-beta.0", ExpectedResult = "1.2.3-beta")]
		[TestCase("1.2.3-beta.2", ExpectedResult = "1.2.3-beta.2")]
		[TestCase("1.2.3-rc.999", ExpectedResult = "1.2.3-rc.999")]
		public string SupportedCase(string input) {
			var semver = new SematicVersion(input);
			return semver.ToString();
		}

		[TestCase("a.b.c")]
		[TestCase("1.0.c")]
		[TestCase("1.a.c")]
		[TestCase("a.a.1")]
		[TestCase("")]
		[TestCase("1")]
		[TestCase("1.2")]
		[TestCase("1.2-a")]
		public void InvalidCases(string input) {
			TestDelegate testDelegate = new TestDelegate(() => {
				var semver = new SematicVersion(input);
			});
			Assert.Catch(testDelegate);
		}

		[TestCase("1.2.3-a.b")]
		[TestCase("1.2.3-a.1.2")]
		[TestCase("1.2.3-1.1.2")]
		[TestCase("1.2.3-2-abc")]
		[TestCase("1.2.3-2")]
		public void ValidButNotSupported(string input) {
			TestDelegate testDelegate = new TestDelegate(() => {
				var semver = new SematicVersion(input);
			});
			Assert.Catch(testDelegate);
		}
	}
}
