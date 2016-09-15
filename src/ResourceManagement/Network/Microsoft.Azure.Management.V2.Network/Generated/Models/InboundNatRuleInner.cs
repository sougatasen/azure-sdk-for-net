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
    /// Inbound NAT rule of the loadbalancer
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class InboundNatRuleInner : Microsoft.Rest.Azure.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the InboundNatRuleInner class.
        /// </summary>
        public InboundNatRuleInner() { }

        /// <summary>
        /// Initializes a new instance of the InboundNatRuleInner class.
        /// </summary>
        /// <param name="frontendIPConfiguration">Gets or sets a reference to
        /// frontend IP Addresses</param>
        /// <param name="backendIPConfiguration">Gets or sets a reference to a
        /// private ip address defined on a NetworkInterface of a VM. Traffic
        /// sent to frontendPort of each of the frontendIPConfigurations is
        /// forwarded to the backed IP</param>
        /// <param name="protocol">Gets or sets the transport potocol for the
        /// endpoint. Possible values are Udp or Tcp. Possible values
        /// include: 'Udp', 'Tcp'</param>
        /// <param name="frontendPort">Gets or sets the port for the external
        /// endpoint. You can spcify any port number you choose, but the port
        /// numbers specified for each role in the service must be unique.
        /// Possible values range between 1 and 65535, inclusive</param>
        /// <param name="backendPort">Gets or sets a port used for internal
        /// connections on the endpoint. The localPort attribute maps the
        /// eternal port of the endpoint to an internal port on a role. This
        /// is useful in scenarios where a role must communicate to an
        /// internal compotnent on a port that is different from the one that
        /// is exposed externally. If not specified, the value of localPort
        /// is the same as the port attribute. Set the value of localPort to
        /// '*' to automatically assign an unallocated port that is
        /// discoverable using the runtime API</param>
        /// <param name="idleTimeoutInMinutes">Gets or sets the timeout for
        /// the Tcp idle connection. The value can be set between 4 and 30
        /// minutes. The default value is 4 minutes. This emlement is only
        /// used when the protocol is set to Tcp</param>
        /// <param name="enableFloatingIP">Configures a virtual machine's
        /// endpoint for the floating IP capability required to configure a
        /// SQL AlwaysOn availability Group. This setting is required when
        /// using the SQL Always ON availability Groups in SQL server. This
        /// setting can't be changed after you create the endpoint</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// PublicIP resource Updating/Deleting/Failed</param>
        /// <param name="name">Gets name of the resource that is unique within
        /// a resource group. This name can be used to access the
        /// resource</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated</param>
        public InboundNatRuleInner(string id = default(string), Microsoft.Rest.Azure.SubResource frontendIPConfiguration = default(Microsoft.Rest.Azure.SubResource), NetworkInterfaceIPConfigurationInner backendIPConfiguration = default(NetworkInterfaceIPConfigurationInner), string protocol = default(string), int? frontendPort = default(int?), int? backendPort = default(int?), int? idleTimeoutInMinutes = default(int?), bool? enableFloatingIP = default(bool?), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            FrontendIPConfiguration = frontendIPConfiguration;
            BackendIPConfiguration = backendIPConfiguration;
            Protocol = protocol;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets a reference to frontend IP Addresses
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public Microsoft.Rest.Azure.SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a reference to a private ip address defined on a
        /// NetworkInterface of a VM. Traffic sent to frontendPort of each of
        /// the frontendIPConfigurations is forwarded to the backed IP
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backendIPConfiguration")]
        public NetworkInterfaceIPConfigurationInner BackendIPConfiguration { get; private set; }

        /// <summary>
        /// Gets or sets the transport potocol for the endpoint. Possible
        /// values are Udp or Tcp. Possible values include: 'Udp', 'Tcp'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the port for the external endpoint. You can spcify
        /// any port number you choose, but the port numbers specified for
        /// each role in the service must be unique. Possible values range
        /// between 1 and 65535, inclusive
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.frontendPort")]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets a port used for internal connections on the endpoint.
        /// The localPort attribute maps the eternal port of the endpoint to
        /// an internal port on a role. This is useful in scenarios where a
        /// role must communicate to an internal compotnent on a port that is
        /// different from the one that is exposed externally. If not
        /// specified, the value of localPort is the same as the port
        /// attribute. Set the value of localPort to '*' to automatically
        /// assign an unallocated port that is discoverable using the runtime
        /// API
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.backendPort")]
        public int? BackendPort { get; set; }

        /// <summary>
        /// Gets or sets the timeout for the Tcp idle connection. The value
        /// can be set between 4 and 30 minutes. The default value is 4
        /// minutes. This emlement is only used when the protocol is set to
        /// Tcp
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets configures a virtual machine's endpoint for the
        /// floating IP capability required to configure a SQL AlwaysOn
        /// availability Group. This setting is required when using the SQL
        /// Always ON availability Groups in SQL server. This setting can't
        /// be changed after you create the endpoint
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableFloatingIP")]
        public bool? EnableFloatingIP { get; set; }

        /// <summary>
        /// Gets provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
