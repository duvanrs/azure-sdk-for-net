// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Certificate that can be installed on Compute Nodes and can be used to
    /// authenticate operations on the machine.
    /// </summary>
    public partial class Certificate
    {
        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        public Certificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Certificate class.
        /// </summary>
        /// <param name="thumbprint">The X.509 thumbprint of the Certificate.
        /// This is a sequence of up to 40 hex digits.</param>
        /// <param name="thumbprintAlgorithm">The algorithm used to derive the
        /// thumbprint.</param>
        /// <param name="url">The URL of the Certificate.</param>
        /// <param name="state">The current state of the Certificate.</param>
        /// <param name="stateTransitionTime">The time at which the Certificate
        /// entered its current state.</param>
        /// <param name="previousState">The previous state of the
        /// Certificate.</param>
        /// <param name="previousStateTransitionTime">The time at which the
        /// Certificate entered its previous state.</param>
        /// <param name="publicData">The public part of the Certificate as a
        /// base-64 encoded .cer file.</param>
        /// <param name="deleteCertificateError">The error that occurred on the
        /// last attempt to delete this Certificate.</param>
        public Certificate(string thumbprint = default(string), string thumbprintAlgorithm = default(string), string url = default(string), CertificateState? state = default(CertificateState?), System.DateTime? stateTransitionTime = default(System.DateTime?), CertificateState? previousState = default(CertificateState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), string publicData = default(string), DeleteCertificateError deleteCertificateError = default(DeleteCertificateError))
        {
            Thumbprint = thumbprint;
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Url = url;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            PublicData = publicData;
            DeleteCertificateError = deleteCertificateError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the X.509 thumbprint of the Certificate. This is a
        /// sequence of up to 40 hex digits.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the algorithm used to derive the thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprintAlgorithm")]
        public string ThumbprintAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the URL of the Certificate.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the current state of the Certificate.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'deleting', 'deleteFailed'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public CertificateState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Certificate entered its current
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the Certificate.
        /// </summary>
        /// <remarks>
        /// This property is not set if the Certificate is in its initial
        /// active state. Possible values include: 'active', 'deleting',
        /// 'deleteFailed'
        /// </remarks>
        [JsonProperty(PropertyName = "previousState")]
        public CertificateState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Certificate entered its previous
        /// state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the Certificate is in its initial
        /// Active state.
        /// </remarks>
        [JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the public part of the Certificate as a base-64
        /// encoded .cer file.
        /// </summary>
        [JsonProperty(PropertyName = "publicData")]
        public string PublicData { get; set; }

        /// <summary>
        /// Gets or sets the error that occurred on the last attempt to delete
        /// this Certificate.
        /// </summary>
        /// <remarks>
        /// This property is set only if the Certificate is in the DeleteFailed
        /// state.
        /// </remarks>
        [JsonProperty(PropertyName = "deleteCertificateError")]
        public DeleteCertificateError DeleteCertificateError { get; set; }

    }
}