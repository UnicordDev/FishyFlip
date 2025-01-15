// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class GeneratorView : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratorView"/> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="cid"></param>
        /// <param name="did"></param>
        /// <param name="creator">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ProfileView"/> (app.bsky.actor.defs#profileView)
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="descriptionFacets"></param>
        /// <param name="avatar"></param>
        /// <param name="likeCount"></param>
        /// <param name="acceptsInteractions"></param>
        /// <param name="labels"></param>
        /// <param name="viewer">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.GeneratorViewerState"/> (app.bsky.feed.defs#generatorViewerState)
        /// </param>
        /// <param name="indexedAt"></param>
        public GeneratorView(FishyFlip.Models.ATUri? uri = default, string? cid = default, FishyFlip.Models.ATDid? did = default, FishyFlip.Lexicon.App.Bsky.Actor.ProfileView? creator = default, string? displayName = default, string? description = default, List<FishyFlip.Lexicon.App.Bsky.Richtext.Facet>? descriptionFacets = default, string? avatar = default, long? likeCount = default, bool? acceptsInteractions = default, List<FishyFlip.Lexicon.Com.Atproto.Label.Label>? labels = default, FishyFlip.Lexicon.App.Bsky.Feed.GeneratorViewerState? viewer = default, DateTime? indexedAt = default)
        {
            this.Uri = uri;
            this.Cid = cid;
            this.Did = did;
            this.Creator = creator;
            this.DisplayName = displayName;
            this.Description = description;
            this.DescriptionFacets = descriptionFacets;
            this.Avatar = avatar;
            this.LikeCount = likeCount;
            this.AcceptsInteractions = acceptsInteractions;
            this.Labels = labels;
            this.Viewer = viewer;
            this.IndexedAt = indexedAt;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratorView"/> class.
        /// </summary>
        public GeneratorView()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratorView"/> class.
        /// </summary>
        public GeneratorView(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["creator"] is not null) this.Creator = new FishyFlip.Lexicon.App.Bsky.Actor.ProfileView(obj["creator"]);
            if (obj["displayName"] is not null) this.DisplayName = obj["displayName"].AsString();
            if (obj["description"] is not null) this.Description = obj["description"].AsString();
            if (obj["descriptionFacets"] is not null) this.DescriptionFacets = obj["descriptionFacets"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Richtext.Facet(n)).ToList();
            if (obj["avatar"] is not null) this.Avatar = obj["avatar"].AsString();
            if (obj["likeCount"] is not null) this.LikeCount = obj["likeCount"].AsInt64Value();
            if (obj["acceptsInteractions"] is not null) this.AcceptsInteractions = obj["acceptsInteractions"].AsBoolean();
            if (obj["labels"] is not null) this.Labels = obj["labels"].Values.Select(n =>new FishyFlip.Lexicon.Com.Atproto.Label.Label(n)).ToList();
            if (obj["viewer"] is not null) this.Viewer = new FishyFlip.Lexicon.App.Bsky.Feed.GeneratorViewerState(obj["viewer"]);
            if (obj["indexedAt"] is not null) this.IndexedAt = obj["indexedAt"].ToDateTime();
        }

        /// <summary>
        /// Gets or sets the uri.
        /// </summary>
        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        /// <summary>
        /// Gets or sets the cid.
        /// </summary>
        [JsonPropertyName("cid")]
        [JsonRequired]
        public string? Cid { get; set; }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ProfileView"/> (app.bsky.actor.defs#profileView)
        /// </summary>
        [JsonPropertyName("creator")]
        [JsonRequired]
        public FishyFlip.Lexicon.App.Bsky.Actor.ProfileView? Creator { get; set; }

        /// <summary>
        /// Gets or sets the displayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        [JsonRequired]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the descriptionFacets.
        /// </summary>
        [JsonPropertyName("descriptionFacets")]
        public List<FishyFlip.Lexicon.App.Bsky.Richtext.Facet>? DescriptionFacets { get; set; }

        /// <summary>
        /// Gets or sets the avatar.
        /// </summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Gets or sets the likeCount.
        /// </summary>
        [JsonPropertyName("likeCount")]
        public long? LikeCount { get; set; }

        /// <summary>
        /// Gets or sets the acceptsInteractions.
        /// </summary>
        [JsonPropertyName("acceptsInteractions")]
        public bool? AcceptsInteractions { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [JsonPropertyName("labels")]
        public List<FishyFlip.Lexicon.Com.Atproto.Label.Label>? Labels { get; set; }

        /// <summary>
        /// Gets or sets the viewer.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Feed.GeneratorViewerState"/> (app.bsky.feed.defs#generatorViewerState)
        /// </summary>
        [JsonPropertyName("viewer")]
        public FishyFlip.Lexicon.App.Bsky.Feed.GeneratorViewerState? Viewer { get; set; }

        /// <summary>
        /// Gets or sets the indexedAt.
        /// </summary>
        [JsonPropertyName("indexedAt")]
        [JsonRequired]
        public DateTime? IndexedAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.defs#generatorView";

        public const string RecordType = "app.bsky.feed.defs#generatorView";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Feed.GeneratorView>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.GeneratorView>)SourceGenerationContext.Default.AppBskyFeedGeneratorView)!;
        }

        public static GeneratorView FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.GeneratorView>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.GeneratorView>)SourceGenerationContext.Default.AppBskyFeedGeneratorView)!;
        }
    }
}

