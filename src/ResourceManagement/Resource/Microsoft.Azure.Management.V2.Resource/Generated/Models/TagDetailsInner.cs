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
    /// Tag details.
    /// </summary>
    public partial class TagDetailsInner
    {
        /// <summary>
        /// Initializes a new instance of the TagDetailsInner class.
        /// </summary>
        public TagDetailsInner() { }

        /// <summary>
        /// Initializes a new instance of the TagDetailsInner class.
        /// </summary>
        /// <param name="id">The tag ID.</param>
        /// <param name="tagName">The tag name.</param>
        /// <param name="count">The tag count.</param>
        /// <param name="values">The list of tag values.</param>
        public TagDetailsInner(string id = default(string), string tagName = default(string), TagCount count = default(TagCount), System.Collections.Generic.IList<TagValueInner> values = default(System.Collections.Generic.IList<TagValueInner>))
        {
            Id = id;
            TagName = tagName;
            Count = count;
            Values = values;
        }

        /// <summary>
        /// Gets or sets the tag ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the tag name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tagName")]
        public string TagName { get; set; }

        /// <summary>
        /// Gets or sets the tag count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public TagCount Count { get; set; }

        /// <summary>
        /// Gets or sets the list of tag values.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.IList<TagValueInner> Values { get; set; }

    }
}
