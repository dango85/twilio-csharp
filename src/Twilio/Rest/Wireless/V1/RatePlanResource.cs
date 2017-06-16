using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Wireless.V1 
{

    /// <summary>
    /// RatePlanResource
    /// </summary>
    public class RatePlanResource : Resource 
    {
        private static Request BuildReadRequest(ReadRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                "/v1/RatePlans",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static ResourceSet<RatePlanResource> Read(ReadRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RatePlanResource>.FromJson("rate_plans", response.Content);
            return new ResourceSet<RatePlanResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RatePlanResource>> ReadAsync(ReadRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RatePlanResource>.FromJson("rate_plans", response.Content);
            return new ResourceSet<RatePlanResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static ResourceSet<RatePlanResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRatePlanOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RatePlanResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRatePlanOptions{PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<RatePlanResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RatePlanResource>.FromJson("rate_plans", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<RatePlanResource> NextPage(Page<RatePlanResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Wireless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RatePlanResource>.FromJson("rate_plans", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<RatePlanResource> PreviousPage(Page<RatePlanResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Wireless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RatePlanResource>.FromJson("rate_plans", response.Content);
        }

        private static Request BuildFetchRequest(FetchRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                "/v1/RatePlans/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Fetch(FetchRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> FetchAsync(FetchRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRatePlanOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRatePlanOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Wireless,
                "/v1/RatePlans",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Create(CreateRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> CreateAsync(CreateRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="dataEnabled"> The data_enabled </param>
        /// <param name="dataLimit"> The data_limit </param>
        /// <param name="dataMetering"> The data_metering </param>
        /// <param name="messagingEnabled"> The messaging_enabled </param>
        /// <param name="voiceEnabled"> The voice_enabled </param>
        /// <param name="nationalRoamingEnabled"> The national_roaming_enabled </param>
        /// <param name="internationalRoaming"> The international_roaming </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Create(string uniqueName = null, string friendlyName = null, bool? dataEnabled = null, int? dataLimit = null, string dataMetering = null, bool? messagingEnabled = null, bool? voiceEnabled = null, bool? nationalRoamingEnabled = null, List<string> internationalRoaming = null, ITwilioRestClient client = null)
        {
            var options = new CreateRatePlanOptions{UniqueName = uniqueName, FriendlyName = friendlyName, DataEnabled = dataEnabled, DataLimit = dataLimit, DataMetering = dataMetering, MessagingEnabled = messagingEnabled, VoiceEnabled = voiceEnabled, NationalRoamingEnabled = nationalRoamingEnabled, InternationalRoaming = internationalRoaming};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="dataEnabled"> The data_enabled </param>
        /// <param name="dataLimit"> The data_limit </param>
        /// <param name="dataMetering"> The data_metering </param>
        /// <param name="messagingEnabled"> The messaging_enabled </param>
        /// <param name="voiceEnabled"> The voice_enabled </param>
        /// <param name="nationalRoamingEnabled"> The national_roaming_enabled </param>
        /// <param name="internationalRoaming"> The international_roaming </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> CreateAsync(string uniqueName = null, string friendlyName = null, bool? dataEnabled = null, int? dataLimit = null, string dataMetering = null, bool? messagingEnabled = null, bool? voiceEnabled = null, bool? nationalRoamingEnabled = null, List<string> internationalRoaming = null, ITwilioRestClient client = null)
        {
            var options = new CreateRatePlanOptions{UniqueName = uniqueName, FriendlyName = friendlyName, DataEnabled = dataEnabled, DataLimit = dataLimit, DataMetering = dataMetering, MessagingEnabled = messagingEnabled, VoiceEnabled = voiceEnabled, NationalRoamingEnabled = nationalRoamingEnabled, InternationalRoaming = internationalRoaming};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Wireless,
                "/v1/RatePlans/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Update(UpdateRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> UpdateAsync(UpdateRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static RatePlanResource Update(string pathSid, string uniqueName = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateRatePlanOptions(pathSid){UniqueName = uniqueName, FriendlyName = friendlyName};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<RatePlanResource> UpdateAsync(string pathSid, string uniqueName = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateRatePlanOptions(pathSid){UniqueName = uniqueName, FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteRatePlanOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Wireless,
                "/v1/RatePlans/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static bool Delete(DeleteRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete RatePlan parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteRatePlanOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RatePlan </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteRatePlanOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RatePlan </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteRatePlanOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a RatePlanResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RatePlanResource object represented by the provided JSON </returns> 
        public static RatePlanResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RatePlanResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The data_enabled
        /// </summary>
        [JsonProperty("data_enabled")]
        public bool? DataEnabled { get; private set; }
        /// <summary>
        /// The data_metering
        /// </summary>
        [JsonProperty("data_metering")]
        public string DataMetering { get; private set; }
        /// <summary>
        /// The data_limit
        /// </summary>
        [JsonProperty("data_limit")]
        public int? DataLimit { get; private set; }
        /// <summary>
        /// The messaging_enabled
        /// </summary>
        [JsonProperty("messaging_enabled")]
        public bool? MessagingEnabled { get; private set; }
        /// <summary>
        /// The voice_enabled
        /// </summary>
        [JsonProperty("voice_enabled")]
        public bool? VoiceEnabled { get; private set; }
        /// <summary>
        /// The national_roaming_enabled
        /// </summary>
        [JsonProperty("national_roaming_enabled")]
        public bool? NationalRoamingEnabled { get; private set; }
        /// <summary>
        /// The international_roaming
        /// </summary>
        [JsonProperty("international_roaming")]
        public List<string> InternationalRoaming { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private RatePlanResource()
        {

        }
    }

}