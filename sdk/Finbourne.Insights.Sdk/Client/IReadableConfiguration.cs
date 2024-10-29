/*
 * FINBOURNE Insights API
 *
 * Insights is LUSID's troubleshooting, monitoring and audit application. It enables you to quickly identify issues in failed requests, and offers a detailed view of your system's operations.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"150\">150</a>|Elastic Search Error|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"181\">181</a>|Data Filter Application Failure|  | | <a name=\"182\">182</a>|Search Failed|  | | <a name=\"411\">411</a>|Sort Field Does Not Exist|  | | <a name=\"653\">653</a>|Request File Not Found|  | | <a name=\"678\">678</a>|Log not found|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | 
 *
 * The version of the OpenAPI document: 0.0.807
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Finbourne.Insights.Sdk.Client
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadableConfiguration
    {
        /// <summary>
        /// Gets the access token.
        /// </summary>
        /// <value>Access token.</value>
        string AccessToken { get; }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value>
        IDictionary<string, string> ApiKey { get; }

        /// <summary>
        /// Gets the API key prefix.
        /// </summary>
        /// <value>API key prefix.</value>
        IDictionary<string, string> ApiKeyPrefix { get; }

        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>Base path.</value>
        string BasePath { get; }

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time foramt.</value>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <value>Default header.</value>
        [Obsolete("Use DefaultHeaders instead.")]
        IDictionary<string, string> DefaultHeader { get; }

        /// <summary>
        /// Gets the default headers.
        /// </summary>
        /// <value>Default headers.</value>
        IDictionary<string, string> DefaultHeaders { get; }

        /// <summary>
        /// Gets the temp folder path.
        /// </summary>
        /// <value>Temp folder path.</value>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; }

        /// <summary>
        /// Gets the proxy.
        /// </summary>
        /// <value>Proxy.</value>
        WebProxy Proxy { get; }

        /// <summary>
        /// Gets the user agent.
        /// </summary>
        /// <value>User agent.</value>
        string UserAgent { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>Username.</value>
        string Username { get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>Password.</value>
        string Password { get; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        string GetApiKeyWithPrefix(string apiKeyIdentifier);

        /// <summary>
        /// Gets certificate collection to be sent with requests.
        /// </summary>
        /// <value>X509 Certificate collection.</value>
        X509CertificateCollection ClientCertificates { get; }
    }
}
