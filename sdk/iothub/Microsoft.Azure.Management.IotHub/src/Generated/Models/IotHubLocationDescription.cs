// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Public representation of one of the locations where a resource is
    /// provisioned.
    /// </summary>
    public partial class IotHubLocationDescription
    {
        /// <summary>
        /// Initializes a new instance of the IotHubLocationDescription class.
        /// </summary>
        public IotHubLocationDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubLocationDescription class.
        /// </summary>
        /// <param name="location">Azure Geo Regions</param>
        /// <param name="role">Specific Role assigned to this location.
        /// Possible values include: 'primary', 'secondary'</param>
        public IotHubLocationDescription(string location = default(string), string role = default(string))
        {
            Location = location;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure Geo Regions
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets specific Role assigned to this location. Possible
        /// values include: 'primary', 'secondary'
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

    }
}
