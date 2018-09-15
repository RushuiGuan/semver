using System;
using System.Collections.Generic;
using System.Text;
using Albatross.SemVer.Core;

namespace Albatross.SemVer
{
    /// <summary>
    /// Simplified sematic version 2.0
    /// Only support the following formats:
    /// [Manjor#].[Minor#].Patch[#]-[Label].[Revision#]
    /// </summary>
    /// 
    public class SimplifiedSemVerOperation : ISemanticVersionOperation {
        public bool IsSupported => throw new NotImplementedException();

        public bool IsValid => throw new NotImplementedException();

        public bool IsRelease => throw new NotImplementedException();

        public int Compare(SematicVersion x, SematicVersion y) {
            throw new NotImplementedException();
        }

        public string Convert(SematicVersion sematic) {
            throw new NotImplementedException();
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

        public SematicVersion Parse(string version) {
            throw new NotImplementedException();
        }
    }
}
