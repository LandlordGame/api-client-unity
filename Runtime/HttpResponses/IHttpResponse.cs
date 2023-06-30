using System;
using System.Net;
using System.Net.Http.Headers;

namespace ApiClient.Runtime.HttpResponses
{
    public interface IHttpResponse
    {
        /// <summary>
        /// Request has been processed successfully, but status code indicates that the operation was not successful.
        /// </summary>
        bool IsClientError { get; }

        /// <summary>
        /// Request has been processed successfully, but status code indicates that there was a server error.
        /// </summary>
        bool IsServerError { get; }

        /// <summary>
        /// Request has been processed successfully, response body was not an expected JSON object.
        /// </summary>
        bool IsContentParsingError { get; }

        /// <summary>
        /// Request could not been sent or response was not received due to network or hardware failure, there is not content.
        /// </summary>
        bool IsNetworkError { get; }

        /// <summary>
        /// Request has been aborted before the response was received, there is no content.
        /// </summary>
        bool IsAborted { get; }

        /// <summary>
        /// Request has timed out before the response was received, there is no content.
        /// </summary>
        bool IsTimeout { get; }

        /// <summary>
        /// Request has been sucessful.
        /// </summary>
        bool HasNoErrors => !IsServerError && !IsClientError && !IsContentParsingError && !IsNetworkError && !IsAborted && !IsTimeout;

        Uri RequestUri { get; }
        HttpResponseHeaders Headers { get; }
    }

    public interface IHttpResponseStatusCode
    {
        /// <summary>
        /// Response status code
        /// </summary>
        HttpStatusCode StatusCode { get; }
    }
}