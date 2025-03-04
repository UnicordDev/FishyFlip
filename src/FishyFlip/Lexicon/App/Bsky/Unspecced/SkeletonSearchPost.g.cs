// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Unspecced
{
    public partial class SkeletonSearchPost : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchPost"/> class.
        /// </summary>
        /// <param name="uri"></param>
        public SkeletonSearchPost(FishyFlip.Models.ATUri uri = default)
        {
            this.Uri = uri;
            this.Type = "app.bsky.unspecced.defs#skeletonSearchPost";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchPost"/> class.
        /// </summary>
        public SkeletonSearchPost()
        {
            this.Type = "app.bsky.unspecced.defs#skeletonSearchPost";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchPost"/> class.
        /// </summary>
        public SkeletonSearchPost(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
        }

        /// <summary>
        /// Gets or sets the uri.
        /// </summary>
        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri Uri { get; set; }

        public const string RecordType = "app.bsky.unspecced.defs#skeletonSearchPost";

        public static SkeletonSearchPost FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Unspecced.SkeletonSearchPost>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Unspecced.SkeletonSearchPost>)SourceGenerationContext.Default.AppBskyUnspeccedSkeletonSearchPost)!;
        }
    }
}

