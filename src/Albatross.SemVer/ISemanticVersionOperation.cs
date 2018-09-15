using System;
using System.Collections.Generic;

namespace Albatross.SemVer {
    public interface ISemanticVersionOperation {
		bool IsSupported(SematicVersion semver);

		void Next();
        void NextMajor();
        void NextMinor();
        void NextPatch();
        void NextRelease();
    }
}
