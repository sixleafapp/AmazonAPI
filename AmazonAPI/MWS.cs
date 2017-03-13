using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceWebServiceProducts;
using MarketplaceWebServiceProducts.Model;
using MWSClientCsRuntime;
using System.Net;

namespace MWS
{
    public class AmazonAPI
    {

        string AppName { get; }
        string AppVersion { get; }
        string AccessKey { get; }
        string SecretKey { get; }
        string ServiceURL { get; }

        public AmazonAPI(string appName, string appVersion, string accessKey, string secretKey, string serviceURL)
        {
            this.AppName = appName;
            this.AppVersion = appVersion;
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.ServiceURL = serviceURL;
        }
        public class APIResults
        {
            string RequestId { get; set; }
            string Timestamp { get; set; }
            string ResponseXml { get; set; }
            string ExMessage { get; set; }
            HttpStatusCode ExStatusCode { get; set; }
            string ExErrorCode { get; set; }
            string ExErrorType { get; set; }
            bool Success { get; set; }

            public APIResults(IMWSResponse response, MwsException ex, bool success)
            {
                MWSClientCsRuntime.MwsResponseHeaderMetadata rhmd;
                Success = success;
                if (Success)
                {
                    rhmd = response.ResponseHeaderMetadata;
                    RequestId = rhmd.RequestId;
                    Timestamp = rhmd.Timestamp;
                    ResponseXml = response.ToXML();
                }
                else
                {
                    rhmd = ex.ResponseHeaderMetadata;
                    RequestId = rhmd.RequestId;
                    Timestamp = rhmd.Timestamp;
                    ExMessage = ex.Message;
                    ExStatusCode = ex.StatusCode;
                    ExErrorCode = ex.ErrorCode;
                    ExErrorType = ex.ErrorType;
                }
            }
            public APIResults(IMWSResponse response) : this(response, null, true) { }
            public APIResults(MwsException ex) : this(null, ex, true) { }
        }
   
        public partial class MarketplaceWebServiceProducts
        {}
    }
}
 
