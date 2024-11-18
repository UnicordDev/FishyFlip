// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    /// <summary>
    /// Record declaring of the existence of a feed generator, and containing metadata about it. The record can exist in any repository.
    /// </summary>
    public partial class Generator : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Generator"/> class.
        /// </summary>
        public Generator()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Generator"/> class.
        /// </summary>
        public Generator(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["displayName"] is not null) this.DisplayName = obj["displayName"].AsString();
            if (obj["description"] is not null) this.Description = obj["description"].AsString();
            if (obj["descriptionFacets"] is not null) this.DescriptionFacets = obj["descriptionFacets"].Values.Select(n => n is not null ? new App.Bsky.Richtext.Facet(n) : null).ToList();
            if (obj["avatar"] is not null) this.Avatar = new FishyFlip.Models.Blob(obj["avatar"]);
            if (obj["acceptsInteractions"] is not null) this.AcceptsInteractions = obj["acceptsInteractions"].AsBoolean();
            if (obj["labels"] is not null) this.Labels = obj["labels"].ToATObject();
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
        }

        [JsonPropertyName("did")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("descriptionFacets")]
        public List<App.Bsky.Richtext.Facet?>? DescriptionFacets { get; set; }

        [JsonPropertyName("avatar")]
        public Blob? Avatar { get; set; }

        /// <summary>
        /// Declaration that a feed accepts feedback interactions from a client through app.bsky.feed.sendInteractions
        /// </summary>
        [JsonPropertyName("acceptsInteractions")]
        public bool? AcceptsInteractions { get; set; }

        /// <summary>
        /// Self-label values
        /// </summary>
        [JsonPropertyName("labels")]
        public ATObject? Labels { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.generator";

        public const string RecordType = "app.bsky.feed.generator";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.Generator>(this, (JsonTypeInfo<App.Bsky.Feed.Generator>)SourceGenerationContext.Default.AppBskyFeedGenerator)!;
        }

        public static Generator FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.Generator>(json, (JsonTypeInfo<App.Bsky.Feed.Generator>)SourceGenerationContext.Default.AppBskyFeedGenerator)!;
        }
    }
}

