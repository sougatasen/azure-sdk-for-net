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
    /// A common class for general resource information
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayInner : Microsoft.Rest.Azure.Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayInner class.
        /// </summary>
        public VirtualNetworkGatewayInner() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayInner class.
        /// </summary>
        /// <param name="ipConfigurations">IpConfigurations for Virtual
        /// network gateway.</param>
        /// <param name="gatewayType">The type of this virtual network
        /// gateway. Possible values include: 'Vpn', 'ExpressRoute'</param>
        /// <param name="vpnType">The type of this virtual network gateway.
        /// Possible values include: 'PolicyBased', 'RouteBased'</param>
        /// <param name="enableBgp">EnableBgp Flag</param>
        /// <param name="gatewayDefaultSite">Gets or sets the reference of the
        /// LocalNetworkGateway resource which represents Local network site
        /// having default routes. Assign Null value in case of removing
        /// existing default site setting.</param>
        /// <param name="sku">Gets or sets the reference of the
        /// VirtualNetworkGatewaySku resource which represents the sku
        /// selected for Virtual network gateway.</param>
        /// <param name="vpnClientConfiguration">Gets or sets the reference of
        /// the VpnClientConfiguration resource which represents the P2S
        /// VpnClient configurations.</param>
        /// <param name="bgpSettings">Virtual network gateway's BGP speaker
        /// settings</param>
        /// <param name="resourceGuid">Gets or sets resource guid property of
        /// the VirtualNetworkGateway resource</param>
        /// <param name="provisioningState">Gets provisioning state of the
        /// VirtualNetworkGateway resource Updating/Deleting/Failed</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated</param>
        public VirtualNetworkGatewayInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), System.Collections.Generic.IList<VirtualNetworkGatewayIPConfigurationInner> ipConfigurations = default(System.Collections.Generic.IList<VirtualNetworkGatewayIPConfigurationInner>), string gatewayType = default(string), string vpnType = default(string), bool? enableBgp = default(bool?), Microsoft.Rest.Azure.SubResource gatewayDefaultSite = default(Microsoft.Rest.Azure.SubResource), VirtualNetworkGatewaySku sku = default(VirtualNetworkGatewaySku), VpnClientConfiguration vpnClientConfiguration = default(VpnClientConfiguration), BgpSettings bgpSettings = default(BgpSettings), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            IpConfigurations = ipConfigurations;
            GatewayType = gatewayType;
            VpnType = vpnType;
            EnableBgp = enableBgp;
            GatewayDefaultSite = gatewayDefaultSite;
            Sku = sku;
            VpnClientConfiguration = vpnClientConfiguration;
            BgpSettings = bgpSettings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
        }

        /// <summary>
        /// Gets or sets ipConfigurations for Virtual network gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ipConfigurations")]
        public System.Collections.Generic.IList<VirtualNetworkGatewayIPConfigurationInner> IpConfigurations { get; set; }

        /// <summary>
        /// Gets or sets the type of this virtual network gateway. Possible
        /// values include: 'Vpn', 'ExpressRoute'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.gatewayType")]
        public string GatewayType { get; set; }

        /// <summary>
        /// Gets or sets the type of this virtual network gateway. Possible
        /// values include: 'PolicyBased', 'RouteBased'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vpnType")]
        public string VpnType { get; set; }

        /// <summary>
        /// Gets or sets enableBgp Flag
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets the reference of the LocalNetworkGateway resource
        /// which represents Local network site having default routes. Assign
        /// Null value in case of removing existing default site setting.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.gatewayDefaultSite")]
        public Microsoft.Rest.Azure.SubResource GatewayDefaultSite { get; set; }

        /// <summary>
        /// Gets or sets the reference of the VirtualNetworkGatewaySku
        /// resource which represents the sku selected for Virtual network
        /// gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sku")]
        public VirtualNetworkGatewaySku Sku { get; set; }

        /// <summary>
        /// Gets or sets the reference of the VpnClientConfiguration resource
        /// which represents the P2S VpnClient configurations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vpnClientConfiguration")]
        public VpnClientConfiguration VpnClientConfiguration { get; set; }

        /// <summary>
        /// Gets or sets virtual network gateway's BGP speaker settings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the VirtualNetworkGateway
        /// resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets provisioning state of the VirtualNetworkGateway resource
        /// Updating/Deleting/Failed
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
