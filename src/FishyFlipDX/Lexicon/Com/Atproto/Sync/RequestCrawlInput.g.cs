// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Sync
{
    public partial class RequestCrawlInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCrawlInput"/> class.
        /// </summary>
        /// <param name="hostname">Hostname of the current service (eg, PDS) that is requesting to be crawled.</param>
        public RequestCrawlInput(string? hostname = default)
        {
            this.Hostname = hostname;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCrawlInput"/> class.
        /// </summary>
        public RequestCrawlInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCrawlInput"/> class.
        /// </summary>
        public RequestCrawlInput(CBORObject obj)
        {
            if (obj["hostname"] is not null) this.Hostname = obj["hostname"].AsString();
        }

        /// <summary>
        /// Gets or sets the hostname.
        /// Hostname of the current service (eg, PDS) that is requesting to be crawled.
        /// </summary>
        [JsonPropertyName("hostname")]
        [JsonRequired]
        public string? Hostname { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.sync.requestCrawl#RequestCrawlInput";

        public const string RecordType = "com.atproto.sync.requestCrawl#RequestCrawlInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Sync.RequestCrawlInput>(this, (JsonTypeInfo<Com.Atproto.Sync.RequestCrawlInput>)SourceGenerationContext.Default.ComAtprotoSyncRequestCrawlInput)!;
        }

        public static RequestCrawlInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Sync.RequestCrawlInput>(json, (JsonTypeInfo<Com.Atproto.Sync.RequestCrawlInput>)SourceGenerationContext.Default.ComAtprotoSyncRequestCrawlInput)!;
        }
    }
}

