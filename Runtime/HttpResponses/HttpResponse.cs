using System;
using System.Net;
using System.Net.Http.Headers;

namespace ApiClient.Runtime.HttpResponses
{
    public class HttpResponse : IHttpResponse, IHttpResponseStatusCode
    {
        public HttpResponse(Uri uri, HttpResponseHeaders headers, HttpStatusCode statusCode)
        {
            RequestUri = uri;
            StatusCode = statusCode;
            Headers = headers;
        }

        public bool IsClientError => (int)StatusCode >= 400 && (int)StatusCode < 500;
        public bool IsServerError => (int)StatusCode >= 500;
        public bool IsContentParsingError => false;
        public bool IsNetworkError => false;
        public bool IsAborted => false;
        public bool IsTimeout => false;
        public Uri RequestUri { get; private set; }
        public HttpStatusCode StatusCode { get; private set; }
        public HttpResponseHeaders Headers { get; private set; }
    }
}