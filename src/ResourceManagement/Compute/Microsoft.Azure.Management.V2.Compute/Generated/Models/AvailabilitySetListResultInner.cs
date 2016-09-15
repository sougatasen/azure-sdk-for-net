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
    /// The List Availability Set operation response.
    /// </summary>
    public partial class AvailabilitySetListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the AvailabilitySetListResultInner
        /// class.
        /// </summary>
        public AvailabilitySetListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the AvailabilitySetListResultInner
        /// class.
        /// </summary>
        /// <param name="value">the list of availability sets</param>
        public AvailabilitySetListResultInner(System.Collections.Generic.IList<AvailabilitySetInner> value = default(System.Collections.Generic.IList<AvailabilitySetInner>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the list of availability sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<AvailabilitySetInner> Value { get; set; }

    }
}
