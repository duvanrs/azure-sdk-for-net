// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The information of an AvailablePrivateEndpointType.
    /// </summary>
    public partial class AvailablePrivateEndpointType
    {
        /// <summary>
        /// Initializes a new instance of the AvailablePrivateEndpointType
        /// class.
        /// </summary>
        public AvailablePrivateEndpointType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailablePrivateEndpointType
        /// class.
        /// </summary>
        /// <param name="name">The name of the service and resource.</param>
        /// <param name="id">A unique identifier of the
        /// AvailablePrivateEndpoint Type resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="resourceName">The name of the service and
        /// resource.</param>
        public AvailablePrivateEndpointType(string name = default(string), string id = default(string), string type = default(string), string resourceName = default(string))
        {
            Name = name;
            Id = id;
            Type = type;
            ResourceName = resourceName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the service and resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier of the AvailablePrivateEndpoint
        /// Type resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the service and resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

    }
}