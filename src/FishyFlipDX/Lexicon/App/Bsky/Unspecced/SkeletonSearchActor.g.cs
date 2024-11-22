// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Unspecced
{
    public partial class SkeletonSearchActor : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchActor"/> class.
        /// </summary>
        /// <param name="did"></param>
        public SkeletonSearchActor(FishyFlip.Models.ATDid? did = default)
        {
            this.Did = did;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchActor"/> class.
        /// </summary>
        public SkeletonSearchActor()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SkeletonSearchActor"/> class.
        /// </summary>
        public SkeletonSearchActor(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.unspecced.defs#skeletonSearchActor";

        public const string RecordType = "app.bsky.unspecced.defs#skeletonSearchActor";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Unspecced.SkeletonSearchActor>(this, (JsonTypeInfo<App.Bsky.Unspecced.SkeletonSearchActor>)SourceGenerationContext.Default.AppBskyUnspeccedSkeletonSearchActor)!;
        }

        public static SkeletonSearchActor FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Unspecced.SkeletonSearchActor>(json, (JsonTypeInfo<App.Bsky.Unspecced.SkeletonSearchActor>)SourceGenerationContext.Default.AppBskyUnspeccedSkeletonSearchActor)!;
        }
    }
}

