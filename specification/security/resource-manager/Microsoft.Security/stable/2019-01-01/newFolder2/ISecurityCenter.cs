// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Settings
{
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// API spec for Microsoft.Security (Azure Security Center) resource
    /// provider
    /// </summary>
    public partial interface ISecurityCenter : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Azure subscription ID
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// API version for the operation
        /// </summary>
        string ApiVersion { get; set; }


        /// <summary>
        /// Gets the ISettings.
        /// </summary>
        ISettings Settings { get; }

    }
}
