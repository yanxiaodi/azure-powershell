// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The azure table storage linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureTableStorage")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureTableStorageLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureTableStorageLinkedService
        /// class.
        /// </summary>
        public PSAzureTableStorageLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string. It is mutually exclusive with
        /// sasUri property. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of accountKey in
        /// connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accountKey")]
        public AzureKeyVaultSecretReference AccountKey { get; set; }

        /// <summary>
        /// Gets or sets SAS URI of the Azure Storage resource. It is mutually
        /// exclusive with connectionString property. Type: string,
        /// SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sasUri")]
        public object SasUri { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of sasToken in
        /// sas uri.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sasToken")]
        public AzureKeyVaultSecretReference SasToken { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential { get; set; }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AzureTableStorageLinkedService();
            linkedService.ConnectionString = this.ConnectionString;
            linkedService.AccountKey = this.AccountKey;
            linkedService.SasUri = this.SasUri;
            linkedService.SasToken = this.SasToken;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            SetProperties(linkedService);
            return linkedService;
        }
    }
}

