// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Deployment properties with additional details.
    /// </summary>
    public partial class DeploymentPropertiesExtended
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentPropertiesExtended
        /// class.
        /// </summary>
        public DeploymentPropertiesExtended() { }

        /// <summary>
        /// Initializes a new instance of the DeploymentPropertiesExtended
        /// class.
        /// </summary>
        /// <param name="provisioningState">The state of the
        /// provisioning.</param>
        /// <param name="correlationId">The correlation ID of the
        /// deployment.</param>
        /// <param name="timestamp">The timestamp of the template
        /// deployment.</param>
        /// <param name="outputs">Key/value pairs that represent
        /// deploymentoutput.</param>
        /// <param name="providers">The list of resource providers needed for
        /// the deployment.</param>
        /// <param name="dependencies">The list of deployment
        /// dependencies.</param>
        /// <param name="template">The template content. Use only one of
        /// Template or TemplateLink.</param>
        /// <param name="templateLink">The URI referencing the template. Use
        /// only one of Template or TemplateLink.</param>
        /// <param name="parameters">Deployment parameters. Use only one of
        /// Parameters or ParametersLink.</param>
        /// <param name="parametersLink">The URI referencing the parameters.
        /// Use only one of Parameters or ParametersLink.</param>
        /// <param name="mode">The deployment mode. Possible values include:
        /// 'Incremental', 'Complete'</param>
        /// <param name="debugSetting">The debug setting of the
        /// deployment.</param>
        public DeploymentPropertiesExtended(string provisioningState = default(string), string correlationId = default(string), System.DateTime? timestamp = default(System.DateTime?), object outputs = default(object), System.Collections.Generic.IList<ProviderInner> providers = default(System.Collections.Generic.IList<ProviderInner>), System.Collections.Generic.IList<Dependency> dependencies = default(System.Collections.Generic.IList<Dependency>), object template = default(object), TemplateLink templateLink = default(TemplateLink), object parameters = default(object), ParametersLink parametersLink = default(ParametersLink), DeploymentMode? mode = default(DeploymentMode?), DebugSetting debugSetting = default(DebugSetting))
        {
            ProvisioningState = provisioningState;
            CorrelationId = correlationId;
            Timestamp = timestamp;
            Outputs = outputs;
            Providers = providers;
            Dependencies = dependencies;
            Template = template;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
        }

        /// <summary>
        /// Gets or sets the state of the provisioning.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the correlation ID of the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the template deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets key/value pairs that represent deploymentoutput.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outputs")]
        public object Outputs { get; set; }

        /// <summary>
        /// Gets or sets the list of resource providers needed for the
        /// deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "providers")]
        public System.Collections.Generic.IList<ProviderInner> Providers { get; set; }

        /// <summary>
        /// Gets or sets the list of deployment dependencies.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dependencies")]
        public System.Collections.Generic.IList<Dependency> Dependencies { get; set; }

        /// <summary>
        /// Gets or sets the template content. Use only one of Template or
        /// TemplateLink.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets the URI referencing the template. Use only one of
        /// Template or TemplateLink.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "templateLink")]
        public TemplateLink TemplateLink { get; set; }

        /// <summary>
        /// Gets or sets deployment parameters. Use only one of Parameters or
        /// ParametersLink.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; set; }

        /// <summary>
        /// Gets or sets the URI referencing the parameters. Use only one of
        /// Parameters or ParametersLink.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parametersLink")]
        public ParametersLink ParametersLink { get; set; }

        /// <summary>
        /// Gets or sets the deployment mode. Possible values include:
        /// 'Incremental', 'Complete'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mode")]
        public DeploymentMode? Mode { get; set; }

        /// <summary>
        /// Gets or sets the debug setting of the deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "debugSetting")]
        public DebugSetting DebugSetting { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.TemplateLink != null)
            {
                this.TemplateLink.Validate();
            }
            if (this.ParametersLink != null)
            {
                this.ParametersLink.Validate();
            }
        }
    }
}
