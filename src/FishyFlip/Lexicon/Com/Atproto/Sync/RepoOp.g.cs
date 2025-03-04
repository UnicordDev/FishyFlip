// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Sync
{
    /// <summary>
    /// A repo operation, ie a mutation of a single record.
    /// </summary>
    public partial class RepoOp : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoOp"/> class.
        /// </summary>
        /// <param name="action">
        /// <br/> Known Values: <br/>
        /// create <br/>
        /// update <br/>
        /// delete <br/>
        /// </param>
        /// <param name="path"></param>
        /// <param name="cid">For creates and updates, the new record CID. For deletions, null.</param>
        public RepoOp(string action = default, string path = default, Ipfs.Cid cid = default)
        {
            this.Action = action;
            this.Path = path;
            this.Cid = cid;
            this.Type = "com.atproto.sync.subscribeRepos#repoOp";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RepoOp"/> class.
        /// </summary>
        public RepoOp()
        {
            this.Type = "com.atproto.sync.subscribeRepos#repoOp";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RepoOp"/> class.
        /// </summary>
        public RepoOp(CBORObject obj)
        {
            if (obj["action"] is not null) this.Action = obj["action"].AsString();
            if (obj["path"] is not null) this.Path = obj["path"].AsString();
            if (obj["cid"] is not null) this.Cid = obj["cid"].ToATCid();
        }

        /// <summary>
        /// Gets or sets the action.
        /// <br/> Known Values: <br/>
        /// create <br/>
        /// update <br/>
        /// delete <br/>
        /// </summary>
        [JsonPropertyName("action")]
        [JsonRequired]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonPropertyName("path")]
        [JsonRequired]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the cid.
        /// <br/> For creates and updates, the new record CID. For deletions, null.
        /// </summary>
        [JsonPropertyName("cid")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATCidJsonConverter))]
        public Ipfs.Cid Cid { get; set; }

        public const string RecordType = "com.atproto.sync.subscribeRepos#repoOp";

        public static RepoOp FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Sync.RepoOp>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Sync.RepoOp>)SourceGenerationContext.Default.ComAtprotoSyncRepoOp)!;
        }
    }
}

