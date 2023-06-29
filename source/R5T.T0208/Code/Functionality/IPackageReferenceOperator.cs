using System;

using R5T.T0132;


namespace R5T.T0208
{
    [FunctionalityMarker]
    public partial interface IPackageReferenceOperator : IFunctionalityMarker
    {
        public int Get_HashCode(PackageReference a)
        {
            var output = HashCode.Combine(
                a.Identity,
                a.Version);

            return output;
        }

        public bool Equals_ByName(PackageReference a, PackageReference b)
        {
            if (Instances.NullOperator.NullCheckDeterminesEquality(a, b, out var areEqual))
            {
                return areEqual;
            }

            var output = a.Identity == b.Identity;
            return output;
        }

        public bool Equals_ByValue(PackageReference a, PackageReference b)
        {
            if(Instances.NullOperator.NullCheckDeterminesEquality(a, b, out var areEqual))
            {
                return areEqual;
            }

            var output = true
               && a.Identity == b.Identity
               && a.Version == b.Version
               ;

            return output;
        }

        public string To_String(PackageReference packageReference)
        {
            var output = $"{packageReference.Identity} ({packageReference.Version})";
            return output;
        }
    }
}
