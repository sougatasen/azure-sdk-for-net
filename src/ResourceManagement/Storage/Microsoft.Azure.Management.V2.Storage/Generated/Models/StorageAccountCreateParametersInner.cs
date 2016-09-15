// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the account.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class StorageAccountCreateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountCreateParametersInner class.
        /// </summary>
        public StorageAccountCreateParametersInner()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountCreateParametersInner class.
        /// </summary>
        /// <param name="sku">Required. Gets or sets the sku type.</param>
        /// <param name="kind">Required. Indicates the type of storage
        /// account. Possible values include: 'Storage', 'BlobStorage'</param>
        /// <param name="location">Required. Gets or sets the location of the
        /// resource. This will be one of the supported and registered Azure
        /// Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The
        /// geo region of a resource cannot be changed once it is created,
        /// but if an identical geo region is specified on update the request
        /// will succeed.</param>
        /// <param name="tags">Gets or sets a list of key value pairs that
        /// describe the resource. These tags can be used in viewing and
        /// grouping this resource (across resource groups). A maximum of 15
        /// tags can be provided for a resource. Each tag must have a key no
        /// greater than 128 characters and value no greater than 256
        /// characters.</param>
        /// <param name="customDomain">User domain assigned to the storage
        /// account. Name is the CNAME source. Only one custom domain is
        /// supported per storage account at this time. To clear the existing
        /// custom domain, use an empty string for the custom domain name
        /// property.</param>
        /// <param name="encryption">Provides the encryption settings on the
        /// account. If left unspecified the account encryption settings will
        /// remain. The default setting is unencrypted.</param>
        /// <param name="accessTier">Required for StandardBlob accounts. The
        /// access tier used for billing. Access tier cannot be changed more
        /// than once every 7 days (168 hours). Access tier cannot be set for
        /// StandardLRS, StandardGRS, StandardRAGRS, or PremiumLRS account
        /// types. Possible values include: 'Hot', 'Cool'</param>
        public StorageAccountCreateParametersInner(Sku sku, Kind? kind, string location, System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), CustomDomain customDomain = default(CustomDomain), Encryption encryption = default(Encryption), AccessTier? accessTier = default(AccessTier?))
        {
            Sku = sku;
            Kind = kind;
            Location = location;
            Tags = tags;
            CustomDomain = customDomain;
            Encryption = encryption;
            AccessTier = accessTier;
        }

        /// <summary>
        /// Gets or sets required. Gets or sets the sku type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets required. Indicates the type of storage account.
        /// Possible values include: 'Storage', 'BlobStorage'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public Kind? Kind { get; set; }

        /// <summary>
        /// Gets or sets required. Gets or sets the location of the resource.
        /// This will be one of the supported and registered Azure Geo
        /// Regions (e.g. West US, East US, Southeast Asia, etc.). The geo
        /// region of a resource cannot be changed once it is created, but if
        /// an identical geo region is specified on update the request will
        /// succeed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used in viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided
        /// for a resource. Each tag must have a key no greater than 128
        /// characters and value no greater than 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets user domain assigned to the storage account. Name is
        /// the CNAME source. Only one custom domain is supported per storage
        /// account at this time. To clear the existing custom domain, use an
        /// empty string for the custom domain name property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; set; }

        /// <summary>
        /// Gets or sets provides the encryption settings on the account. If
        /// left unspecified the account encryption settings will remain. The
        /// default setting is unencrypted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets required for StandardBlob accounts. The access tier
        /// used for billing. Access tier cannot be changed more than once
        /// every 7 days (168 hours). Access tier cannot be set for
        /// StandardLRS, StandardGRS, StandardRAGRS, or PremiumLRS account
        /// types. Possible values include: 'Hot', 'Cool'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Sku");
            }
            if (Location == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Location");
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
            if (this.CustomDomain != null)
            {
                this.CustomDomain.Validate();
            }
        }
    }
}
