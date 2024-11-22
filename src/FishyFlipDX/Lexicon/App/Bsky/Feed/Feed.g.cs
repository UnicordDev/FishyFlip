// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class Feed : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Feed"/> class.
        /// </summary>
        /// <param name="uri"></param>
        public Feed(FishyFlip.Models.ATUri? uri = default)
        {
            this.Uri = uri;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Feed"/> class.
        /// </summary>
        public Feed()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Feed"/> class.
        /// </summary>
        public Feed(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
        }

        /// <summary>
        /// Gets or sets the uri.
        /// </summary>
        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.describeFeedGenerator#feed";

        public const string RecordType = "app.bsky.feed.describeFeedGenerator#feed";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.Feed>(this, (JsonTypeInfo<App.Bsky.Feed.Feed>)SourceGenerationContext.Default.AppBskyFeedFeed)!;
        }

        public static Feed FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.Feed>(json, (JsonTypeInfo<App.Bsky.Feed.Feed>)SourceGenerationContext.Default.AppBskyFeedFeed)!;
        }
    }
}

