// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class BlockedAuthor : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedAuthor"/> class.
        /// </summary>
        /// <param name="did"></param>
        /// <param name="viewer">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ViewerState"/> (app.bsky.actor.defs#viewerState)
        /// </param>
        public BlockedAuthor(FishyFlip.Models.ATDid did = default, FishyFlip.Lexicon.App.Bsky.Actor.ViewerState? viewer = default)
        {
            this.Did = did;
            this.Viewer = viewer;
            this.Type = "app.bsky.feed.defs#blockedAuthor";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedAuthor"/> class.
        /// </summary>
        public BlockedAuthor()
        {
            this.Type = "app.bsky.feed.defs#blockedAuthor";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedAuthor"/> class.
        /// </summary>
        public BlockedAuthor(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["viewer"] is not null) this.Viewer = new FishyFlip.Lexicon.App.Bsky.Actor.ViewerState(obj["viewer"]);
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid Did { get; set; }

        /// <summary>
        /// Gets or sets the viewer.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ViewerState"/> (app.bsky.actor.defs#viewerState)
        /// </summary>
        [JsonPropertyName("viewer")]
        public FishyFlip.Lexicon.App.Bsky.Actor.ViewerState? Viewer { get; set; }

        public const string RecordType = "app.bsky.feed.defs#blockedAuthor";

        public static BlockedAuthor FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.BlockedAuthor>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.BlockedAuthor>)SourceGenerationContext.Default.AppBskyFeedBlockedAuthor)!;
        }
    }
}

