// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Unspecced
{
    public partial class SkeletonSearchStarterPack : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchStarterPack"/> class.
        /// </summary>
        /// <param name="uri"></param>
        public SkeletonSearchStarterPack(FishyFlip.Models.ATUri? uri = default)
        {
            this.Uri = uri;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchStarterPack"/> class.
        /// </summary>
        public SkeletonSearchStarterPack()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchStarterPack"/> class.
        /// </summary>
        public SkeletonSearchStarterPack(CBORObject obj)
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
        public override string Type => "app.bsky.unspecced.defs#skeletonSearchStarterPack";

        public const string RecordType = "app.bsky.unspecced.defs#skeletonSearchStarterPack";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Unspecced.SkeletonSearchStarterPack>(this, (JsonTypeInfo<App.Bsky.Unspecced.SkeletonSearchStarterPack>)SourceGenerationContext.Default.AppBskyUnspeccedSkeletonSearchStarterPack)!;
        }

        public static SkeletonSearchStarterPack FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Unspecced.SkeletonSearchStarterPack>(json, (JsonTypeInfo<App.Bsky.Unspecced.SkeletonSearchStarterPack>)SourceGenerationContext.Default.AppBskyUnspeccedSkeletonSearchStarterPack)!;
        }
    }
}

