// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Labeler
{
    public partial class LabelerViewDetailed : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerViewDetailed"/> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="cid"></param>
        /// <param name="creator"></param>
        /// <param name="policies"></param>
        /// <param name="likeCount"></param>
        /// <param name="viewer"></param>
        /// <param name="indexedAt"></param>
        /// <param name="labels"></param>
        public LabelerViewDetailed(FishyFlip.Models.ATUri? uri = default, string? cid = default, App.Bsky.Actor.ProfileView? creator = default, App.Bsky.Labeler.LabelerPolicies? policies = default, long? likeCount = default, App.Bsky.Labeler.LabelerViewerState? viewer = default, DateTime? indexedAt = default, List<Com.Atproto.Label.Label>? labels = default)
        {
            this.Uri = uri;
            this.Cid = cid;
            this.Creator = creator;
            this.Policies = policies;
            this.LikeCount = likeCount;
            this.Viewer = viewer;
            this.IndexedAt = indexedAt;
            this.Labels = labels;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerViewDetailed"/> class.
        /// </summary>
        public LabelerViewDetailed()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerViewDetailed"/> class.
        /// </summary>
        public LabelerViewDetailed(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["creator"] is not null) this.Creator = new App.Bsky.Actor.ProfileView(obj["creator"]);
            if (obj["policies"] is not null) this.Policies = new App.Bsky.Labeler.LabelerPolicies(obj["policies"]);
            if (obj["likeCount"] is not null) this.LikeCount = obj["likeCount"].AsInt64Value();
            if (obj["viewer"] is not null) this.Viewer = new App.Bsky.Labeler.LabelerViewerState(obj["viewer"]);
            if (obj["indexedAt"] is not null) this.IndexedAt = obj["indexedAt"].ToDateTime();
            if (obj["labels"] is not null) this.Labels = obj["labels"].Values.Select(n =>new Com.Atproto.Label.Label(n)).ToList();
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
        /// Gets or sets the creator.
        /// </summary>
        [JsonPropertyName("creator")]
        [JsonRequired]
        public App.Bsky.Actor.ProfileView? Creator { get; set; }

        /// <summary>
        /// Gets or sets the policies.
        /// </summary>
        [JsonPropertyName("policies")]
        [JsonRequired]
        public App.Bsky.Labeler.LabelerPolicies? Policies { get; set; }

        /// <summary>
        /// Gets or sets the likeCount.
        /// </summary>
        [JsonPropertyName("likeCount")]
        public long? LikeCount { get; set; }

        /// <summary>
        /// Gets or sets the viewer.
        /// </summary>
        [JsonPropertyName("viewer")]
        public App.Bsky.Labeler.LabelerViewerState? Viewer { get; set; }

        /// <summary>
        /// Gets or sets the indexedAt.
        /// </summary>
        [JsonPropertyName("indexedAt")]
        [JsonRequired]
        public DateTime? IndexedAt { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [JsonPropertyName("labels")]
        public List<Com.Atproto.Label.Label>? Labels { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.labeler.defs#labelerViewDetailed";

        public const string RecordType = "app.bsky.labeler.defs#labelerViewDetailed";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Labeler.LabelerViewDetailed>(this, (JsonTypeInfo<App.Bsky.Labeler.LabelerViewDetailed>)SourceGenerationContext.Default.AppBskyLabelerLabelerViewDetailed)!;
        }

        public static LabelerViewDetailed FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Labeler.LabelerViewDetailed>(json, (JsonTypeInfo<App.Bsky.Labeler.LabelerViewDetailed>)SourceGenerationContext.Default.AppBskyLabelerLabelerViewDetailed)!;
        }
    }
}

