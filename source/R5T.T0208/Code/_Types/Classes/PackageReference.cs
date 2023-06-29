using System;

using R5T.T0142;


namespace R5T.T0208
{
    /// <summary>
    /// A simple package reference type.
    /// </summary>
    /// <remarks>
    /// Can be used as a dictionary key.
    /// </remarks>
    [DataTypeMarker]
    public sealed class PackageReference : IEquatable<PackageReference>
    {
        #region Static

        public static bool operator ==(PackageReference a, PackageReference b)
        {
            var output = a is null
                ? b is null
                : a.Equals(b)
                ;

            return output;
        }

        public static bool operator !=(PackageReference a, PackageReference b)
        {
            var output = !(a == b);
            return output;
        }

        #endregion


        /// <summary>
        /// Example: Microsoft.AspNetCore.Components.WebAssembly.Server.
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// Example: 6.0.11
        /// </summary>
        public string Version { get; set; }


        public bool Equals(PackageReference other)
        {
            var output = Instances.PackageReferenceOperator.Equals_ByValue(this, other);
            return output;
        }

        public override bool Equals(object obj)
        {
            var objAsPackageReference = obj as PackageReference;

            var output = this.Equals(objAsPackageReference);
            return output;
        }

        public override int GetHashCode()
        {
            return Instances.PackageReferenceOperator.Get_HashCode(this);
        }

        public override string ToString()
        {
            var output = Instances.PackageReferenceOperator.To_String(this);
            return output;
        }
    }
}
