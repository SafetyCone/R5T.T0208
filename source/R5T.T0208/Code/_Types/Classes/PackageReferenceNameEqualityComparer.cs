using System;
using System.Collections.Generic;


namespace R5T.T0208
{
    /// <summary>
    /// An equality comparer that only uses the name (identity) of the package.
    /// </summary>
    public class PackageReferenceNameEqualityComparer : IEqualityComparer<PackageReference>
    {
        #region Static

        public static PackageReferenceNameEqualityComparer Instance = new PackageReferenceNameEqualityComparer();

        #endregion


        public bool Equals(PackageReference x, PackageReference y)
        {
            var output = Instances.PackageReferenceOperator.Equals_ByName(x, y);
            return output;
        }

        public int GetHashCode(PackageReference obj)
        {
            var output = HashCode.Combine(obj.Identity);
            return output;
        }
    }
}
