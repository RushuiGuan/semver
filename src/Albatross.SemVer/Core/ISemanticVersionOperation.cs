using System;
using System.Collections.Generic;

namespace Albatross.SemVer.Core {
    public interface ISemanticVersionOperation :IComparer<SematicVersion> {
        bool IsSupported { get; }
        bool IsValid { get; }
        bool IsRelease { get; }

        SematicVersion Parse(string version);
        string Convert(SematicVersion sematic);

        void Next();
        void NextMajor();
        void NextMinor();
        void NextPatch();
        void NextRelease();
    }
}
