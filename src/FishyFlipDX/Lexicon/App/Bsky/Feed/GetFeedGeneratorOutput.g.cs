// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class GetFeedGeneratorOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedGeneratorOutput"/> class.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="isOnline">Indicates whether the feed generator service has been online recently, or else seems to be inactive.</param>
        /// <param name="isValid">Indicates whether the feed generator service is compatible with the record declaration.</param>
        public GetFeedGeneratorOutput(App.Bsky.Feed.GeneratorView? view = default, bool? isOnline = default, bool? isValid = default)
        {
            this.View = view;
            this.IsOnline = isOnline;
            this.IsValid = isValid;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedGeneratorOutput"/> class.
        /// </summary>
        public GetFeedGeneratorOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedGeneratorOutput"/> class.
        /// </summary>
        public GetFeedGeneratorOutput(CBORObject obj)
        {
            if (obj["view"] is not null) this.View = new App.Bsky.Feed.GeneratorView(obj["view"]);
            if (obj["isOnline"] is not null) this.IsOnline = obj["isOnline"].AsBoolean();
            if (obj["isValid"] is not null) this.IsValid = obj["isValid"].AsBoolean();
        }

        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        [JsonPropertyName("view")]
        [JsonRequired]
        public App.Bsky.Feed.GeneratorView? View { get; set; }

        /// <summary>
        /// Gets or sets the isOnline.
        /// Indicates whether the feed generator service has been online recently, or else seems to be inactive.
        /// </summary>
        [JsonPropertyName("isOnline")]
        [JsonRequired]
        public bool? IsOnline { get; set; }

        /// <summary>
        /// Gets or sets the isValid.
        /// Indicates whether the feed generator service is compatible with the record declaration.
        /// </summary>
        [JsonPropertyName("isValid")]
        [JsonRequired]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.getFeedGenerator#GetFeedGeneratorOutput";

        public const string RecordType = "app.bsky.feed.getFeedGenerator#GetFeedGeneratorOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.GetFeedGeneratorOutput>(this, (JsonTypeInfo<App.Bsky.Feed.GetFeedGeneratorOutput>)SourceGenerationContext.Default.AppBskyFeedGetFeedGeneratorOutput)!;
        }

        public static GetFeedGeneratorOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.GetFeedGeneratorOutput>(json, (JsonTypeInfo<App.Bsky.Feed.GetFeedGeneratorOutput>)SourceGenerationContext.Default.AppBskyFeedGetFeedGeneratorOutput)!;
        }
    }
}

