using System;
using System.Collections.Generic;

namespace Albatross.SemVer {
    public interface ISemanticVersionOperation {
		void Next(SematicVersion sematicVersion, string label);
        void NextMajor(SematicVersion sematicVersion, string label);
        void NextMinor(SematicVersion sematicVersion, string label);
        void NextPatch(SematicVersion sematicVersion, string label);
        void NextRelease(SematicVersion sematicVersion);
    }
}
