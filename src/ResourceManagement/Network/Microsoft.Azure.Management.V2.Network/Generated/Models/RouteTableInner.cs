// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// RouteTable resource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class RouteTableInner : Microsoft.Rest.Azure.Resource
    {
        /// <summary>
        /// Initializes a new instance of the RouteTableInner class.
        /// </summary>
        public RouteTableInner() { }

        /// <summary>
        /// Initializes a new instance of the RouteTableInner class.
        /// </summary>
        /// <param name="routes">Gets or sets Routes in a Route Table</param>
        /// <param name="subnets">Gets collection of references to
        /// subnets</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// resource Updating/Deleting/Failed</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated</param>
        public RouteTableInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), System.Collections.Generic.IList<RouteInner> routes = default(System.Collections.Generic.IList<RouteInner>), System.Collections.Generic.IList<SubnetInner> subnets = default(System.Collections.Generic.IList<SubnetInner>), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Routes = routes;
            Subnets = subnets;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets Routes in a Route Table
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routes")]
        public System.Collections.Generic.IList<RouteInner> Routes { get; set; }

        /// <summary>
        /// Gets collection of references to subnets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.subnets")]
        public System.Collections.Generic.IList<SubnetInner> Subnets { get; private set; }

        /// <summary>
        /// Gets provisioning state of the resource Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
