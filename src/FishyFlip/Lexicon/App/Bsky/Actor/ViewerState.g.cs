// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    /// <summary>
    /// Metadata about the requesting account's relationship with the subject account. Only has meaningful content for authed requests.
    /// </summary>
    public partial class ViewerState : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewerState"/> class.
        /// </summary>
        /// <param name="muted"></param>
        /// <param name="mutedByList">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic"/> (app.bsky.graph.defs#listViewBasic)
        /// </param>
        /// <param name="blockedBy"></param>
        /// <param name="blocking"></param>
        /// <param name="blockingByList">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic"/> (app.bsky.graph.defs#listViewBasic)
        /// </param>
        /// <param name="following"></param>
        /// <param name="followedBy"></param>
        /// <param name="knownFollowers">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Actor.KnownFollowers"/> (app.bsky.actor.defs#knownFollowers)
        /// </param>
        public ViewerState(bool? muted = default, FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic? mutedByList = default, bool? blockedBy = default, FishyFlip.Models.ATUri? blocking = default, FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic? blockingByList = default, FishyFlip.Models.ATUri? following = default, FishyFlip.Models.ATUri? followedBy = default, FishyFlip.Lexicon.App.Bsky.Actor.KnownFollowers? knownFollowers = default)
        {
            this.Muted = muted;
            this.MutedByList = mutedByList;
            this.BlockedBy = blockedBy;
            this.Blocking = blocking;
            this.BlockingByList = blockingByList;
            this.Following = following;
            this.FollowedBy = followedBy;
            this.KnownFollowers = knownFollowers;
            this.Type = "app.bsky.actor.defs#viewerState";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewerState"/> class.
        /// </summary>
        public ViewerState()
        {
            this.Type = "app.bsky.actor.defs#viewerState";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewerState"/> class.
        /// </summary>
        public ViewerState(CBORObject obj)
        {
            if (obj["muted"] is not null) this.Muted = obj["muted"].AsBoolean();
            if (obj["mutedByList"] is not null) this.MutedByList = new FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic(obj["mutedByList"]);
            if (obj["blockedBy"] is not null) this.BlockedBy = obj["blockedBy"].AsBoolean();
            if (obj["blocking"] is not null) this.Blocking = obj["blocking"].ToATUri();
            if (obj["blockingByList"] is not null) this.BlockingByList = new FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic(obj["blockingByList"]);
            if (obj["following"] is not null) this.Following = obj["following"].ToATUri();
            if (obj["followedBy"] is not null) this.FollowedBy = obj["followedBy"].ToATUri();
            if (obj["knownFollowers"] is not null) this.KnownFollowers = new FishyFlip.Lexicon.App.Bsky.Actor.KnownFollowers(obj["knownFollowers"]);
        }

        /// <summary>
        /// Gets or sets the muted.
        /// </summary>
        [JsonPropertyName("muted")]
        public bool? Muted { get; set; }

        /// <summary>
        /// Gets or sets the mutedByList.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic"/> (app.bsky.graph.defs#listViewBasic)
        /// </summary>
        [JsonPropertyName("mutedByList")]
        public FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic? MutedByList { get; set; }

        /// <summary>
        /// Gets or sets the blockedBy.
        /// </summary>
        [JsonPropertyName("blockedBy")]
        public bool? BlockedBy { get; set; }

        /// <summary>
        /// Gets or sets the blocking.
        /// </summary>
        [JsonPropertyName("blocking")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Blocking { get; set; }

        /// <summary>
        /// Gets or sets the blockingByList.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic"/> (app.bsky.graph.defs#listViewBasic)
        /// </summary>
        [JsonPropertyName("blockingByList")]
        public FishyFlip.Lexicon.App.Bsky.Graph.ListViewBasic? BlockingByList { get; set; }

        /// <summary>
        /// Gets or sets the following.
        /// </summary>
        [JsonPropertyName("following")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Following { get; set; }

        /// <summary>
        /// Gets or sets the followedBy.
        /// </summary>
        [JsonPropertyName("followedBy")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? FollowedBy { get; set; }

        /// <summary>
        /// Gets or sets the knownFollowers.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Actor.KnownFollowers"/> (app.bsky.actor.defs#knownFollowers)
        /// </summary>
        [JsonPropertyName("knownFollowers")]
        public FishyFlip.Lexicon.App.Bsky.Actor.KnownFollowers? KnownFollowers { get; set; }

        public const string RecordType = "app.bsky.actor.defs#viewerState";

        public static ViewerState FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.ViewerState>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.ViewerState>)SourceGenerationContext.Default.AppBskyActorViewerState)!;
        }
    }
}

