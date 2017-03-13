using System;
using System.Collections.Generic;
using MarketplaceWebServiceProducts;
using MarketplaceWebServiceProducts.Model;
using static MWS.AmazonAPI;

namespace MWS {
    
    public class MarketplaceWebServiceProducts {

        private MarketplaceWebServiceProductsClient productClient;

        public MarketplaceWebServiceProducts(MarketplaceWebServiceProductsClient client, string sellerId, string mwsAuthToken, string marketplaceId)
        {
            productClient = client;
        }
        public MarketplaceWebServiceProducts(string appName, string appVersion, string accessKey, string secretKey, string serviceURL, string sellerId, string mwsAuthToken, string marketplaceId)
        {
            //Create a configuration object
            MarketplaceWebServiceProductsConfig config = new MarketplaceWebServiceProductsConfig();
            config.ServiceURL = serviceURL;
            // Create the client itself
            productClient = new MarketplaceWebServiceProductsClient(appName, appVersion, accessKey, secretKey, config);
        }


        public GetCompetitivePricingForASINResponse InvokeGetCompetitivePricingForASIN(string sellerId, string mwsAuthToken, string marketplaceId, out APIResults results)
        {
            try
            {
                // Create a request.
                GetCompetitivePricingForASINRequest request = new GetCompetitivePricingForASINRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                ASINListType _asinList = new ASINListType();
                request.ASINList = _asinList;
                GetCompetitivePricingForASINResponse output = this.productClient.GetCompetitivePricingForASIN(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetLowestOfferListingsForASINResponse InvokeGetLowestOfferListingsForASIN(string sellerId, string mwsAuthToken, string marketplaceId, string itemCondition, bool excludeMe, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetLowestOfferListingsForASINRequest request = new GetLowestOfferListingsForASINRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                ASINListType _asinList = new ASINListType();
                request.ASINList = _asinList;
                request.ItemCondition = itemCondition;
                request.ExcludeMe = excludeMe;
                GetLowestOfferListingsForASINResponse output = this.productClient.GetLowestOfferListingsForASIN(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
}

        public GetLowestOfferListingsForSKUResponse InvokeGetLowestOfferListingsForSKU(string sellerId, string mwsAuthToken, string marketplaceId, string itemCondition, bool excludeMe, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetLowestOfferListingsForSKURequest request = new GetLowestOfferListingsForSKURequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                SellerSKUListType _sellerSKUList = new SellerSKUListType();
                request.SellerSKUList = _sellerSKUList;
                request.ItemCondition = itemCondition;
                request.ExcludeMe = excludeMe;
                GetLowestOfferListingsForSKUResponse output = this.productClient.GetLowestOfferListingsForSKU(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetLowestPricedOffersForASINResponse InvokeGetLowestPricedOffersForASIN(string sellerId, string mwsAuthToken, string marketplaceId, string asin, string itemCondition, bool excludeMe, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetLowestPricedOffersForASINRequest request = new GetLowestPricedOffersForASINRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                request.ASIN = asin;
                request.ItemCondition = itemCondition;
                GetLowestPricedOffersForASINResponse output = this.productClient.GetLowestPricedOffersForASIN(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetLowestPricedOffersForSKUResponse InvokeGetLowestPricedOffersForSKU(string sellerId, string mwsAuthToken, string marketplaceId, string sellerSKU, string itemCondition, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetLowestPricedOffersForSKURequest request = new GetLowestPricedOffersForSKURequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                request.SellerSKU = sellerSKU;
                request.ItemCondition = itemCondition;
                GetLowestPricedOffersForSKUResponse output = this.productClient.GetLowestPricedOffersForSKU(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetMatchingProductResponse InvokeGetMatchingProduct(string sellerId, string mwsAuthToken, string marketplaceId, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetMatchingProductRequest request = new GetMatchingProductRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                ASINListType asinList = new ASINListType();
                request.ASINList = asinList;
                GetMatchingProductResponse output = this.productClient.GetMatchingProduct(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetMatchingProductForIdResponse InvokeGetMatchingProductForId(string sellerId, string mwsAuthToken, string marketplaceId, string idType, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetMatchingProductForIdRequest request = new GetMatchingProductForIdRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                request.IdType = idType;
                IdListType idList = new IdListType();
                request.IdList = idList;
                GetMatchingProductForIdResponse output = this.productClient.GetMatchingProductForId(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetMyFeesEstimateResponse InvokeGetMyFeesEstimate(string sellerId, string mwsAuthToken, out APIResults results)
        {
            try
            {
                // Create a request.
                GetMyFeesEstimateRequest request = new GetMyFeesEstimateRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                FeesEstimateRequestList feesEstimateRequestList = new FeesEstimateRequestList();
                request.FeesEstimateRequestList = feesEstimateRequestList;
                GetMyFeesEstimateResponse output = this.productClient.GetMyFeesEstimate(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetMyPriceForASINResponse InvokeGetMyPriceForASIN(string sellerId, string mwsAuthToken, string marketplaceId, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetMyPriceForASINRequest request = new GetMyPriceForASINRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                ASINListType asinList = new ASINListType();
                request.ASINList = asinList;
                GetMyPriceForASINResponse output = this.productClient.GetMyPriceForASIN(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetMyPriceForSKUResponse InvokeGetMyPriceForSKU(string sellerId, string mwsAuthToken, string marketplaceId, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetMyPriceForSKURequest request = new GetMyPriceForSKURequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                SellerSKUListType sellerSKUList = new SellerSKUListType();
                request.SellerSKUList = sellerSKUList;
                GetMyPriceForSKUResponse output = this.productClient.GetMyPriceForSKU(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetProductCategoriesForASINResponse InvokeGetProductCategoriesForASIN(string sellerId, string mwsAuthToken, string marketplaceId, string asin, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetProductCategoriesForASINRequest request = new GetProductCategoriesForASINRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                request.ASIN = asin;
                GetProductCategoriesForASINResponse output = this.productClient.GetProductCategoriesForASIN(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetProductCategoriesForSKUResponse InvokeGetProductCategoriesForSKU(string sellerId, string mwsAuthToken, string marketplaceId, string sellerSKU, out APIResults results)
        {
            try
            {
                // Create a request.
                GetProductCategoriesForSKURequest request = new GetProductCategoriesForSKURequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                request.SellerSKU = sellerSKU;
                GetProductCategoriesForSKUResponse output = this.productClient.GetProductCategoriesForSKU(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public GetServiceStatusResponse InvokeGetServiceStatus(string sellerId, string mwsAuthToken, out APIResults results)
        {
            try
            { 
                // Create a request.
                GetServiceStatusRequest request = new GetServiceStatusRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                GetServiceStatusResponse output = this.productClient.GetServiceStatus(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

        public ListMatchingProductsResponse InvokeListMatchingProducts(string sellerId, string mwsAuthToken, string marketplaceId, string query, string queryContextId, out APIResults results)
        {
            try
            {
                // Create a request.
                ListMatchingProductsRequest request = new ListMatchingProductsRequest();
                request.SellerId = sellerId;
                request.MWSAuthToken = mwsAuthToken;
                request.MarketplaceId = marketplaceId;
                request.Query = query;
                request.QueryContextId = queryContextId;
                ListMatchingProductsResponse output = this.productClient.ListMatchingProducts(request);
                results = new APIResults((IMWSResponse)output);
                return output;
            }
            catch (MarketplaceWebServiceProductsException ex)
            {
                results = new APIResults(ex);
                throw ex;
            }
        }

    }
}
