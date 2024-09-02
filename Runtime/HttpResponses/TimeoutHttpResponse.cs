using System;
using System.Collections.Generic;

namespace ApiClient.Runtime.HttpResponses
{
    public class TimeoutHttpResponse : IHttpResponse
    {
        public bool IsClientError => false;
        public bool IsServerError => false;
        public bool IsNetworkError => false;
        public bool IsAborted => false;
        public bool IsTimeout => true;
        public bool IsContentParsingError => false;
        public Uri RequestUri { get; private set; }
        public Dictionary<string, string> Headers { get; private set; } = null;
        public Dictionary<string, string> ContentHeaders { get; private set; } = null;

        public TimeoutHttpResponse(Uri requestUri)
        {
            RequestUri = requestUri;
        }
    }
}