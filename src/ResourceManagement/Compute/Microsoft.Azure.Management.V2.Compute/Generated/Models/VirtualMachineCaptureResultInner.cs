// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Resource Id.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineCaptureResultInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResultInner
        /// class.
        /// </summary>
        public VirtualMachineCaptureResultInner() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineCaptureResultInner
        /// class.
        /// </summary>
        /// <param name="output">Operation output data (raw JSON)</param>
        public VirtualMachineCaptureResultInner(string id = default(string), object output = default(object))
            : base(id)
        {
            Output = output;
        }

        /// <summary>
        /// Gets or sets operation output data (raw JSON)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.output")]
        public object Output { get; set; }

    }
}
