// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Richtext
{
    /// <summary>
    /// Facet feature for a hashtag. The text usually includes a '#' prefix, but the facet reference should not (except in the case of 'double hash tags').
    /// </summary>
    public partial class Tag : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Tag"/> class.
        /// </summary>
        /// <param name="tag"></param>
        public Tag(string? tag = default)
        {
            this.TagValue = tag;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Tag"/> class.
        /// </summary>
        public Tag()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Tag"/> class.
        /// </summary>
        public Tag(CBORObject obj)
        {
            if (obj["tag"] is not null) this.TagValue = obj["tag"].AsString();
        }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        [JsonPropertyName("tag")]
        [JsonRequired]
        public string? TagValue { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.richtext.facet#tag";

        public const string RecordType = "app.bsky.richtext.facet#tag";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Richtext.Tag>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Richtext.Tag>)SourceGenerationContext.Default.AppBskyRichtextTag)!;
        }

        public static Tag FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Richtext.Tag>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Richtext.Tag>)SourceGenerationContext.Default.AppBskyRichtextTag)!;
        }
    }
}

