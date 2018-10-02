using System;
using System.Collections.Generic;

namespace Albatross.SemVer {
    public interface ISemanticVersionOperation {
		void NextPrerelease(SematicVersion sematicVersion, string label);
        void NextMajor(SematicVersion sematicVersion);
        void NextMinor(SematicVersion sematicVersion);
        void NextPatch(SematicVersion sematicVersion);
    }
}
