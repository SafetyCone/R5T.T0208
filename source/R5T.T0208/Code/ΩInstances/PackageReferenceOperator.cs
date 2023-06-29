using System;


namespace R5T.T0208
{
    public class PackageReferenceOperator : IPackageReferenceOperator
    {
        #region Infrastructure

        public static IPackageReferenceOperator Instance { get; } = new PackageReferenceOperator();


        private PackageReferenceOperator()
        {
        }

        #endregion
    }
}
