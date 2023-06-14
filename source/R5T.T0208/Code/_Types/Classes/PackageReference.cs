using System;

using R5T.T0142;


namespace R5T.T0208
{
    [DataTypeMarker]
    public class PackageReference
    {
        /// <summary>
        /// Example: Microsoft.AspNetCore.Components.WebAssembly.Server.
        /// </summary>
        public string Identity { get; set; }

        /// <summary>
        /// Example: 6.0.11
        /// </summary>
        public string Version { get; set; }
    }
}
