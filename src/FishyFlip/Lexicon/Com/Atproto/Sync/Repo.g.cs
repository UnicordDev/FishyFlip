// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Sync
{
    public partial class Repo : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Repo"/> class.
        /// </summary>
        /// <param name="did"></param>
        /// <param name="head">Current repo commit CID</param>
        /// <param name="rev"></param>
        /// <param name="active"></param>
        /// <param name="status">If active=false, this optional field indicates a possible reason for why the account is not active. If active=false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted.
        /// <br/> Known Values: <br/>
        /// takendown <br/>
        /// suspended <br/>
        /// deactivated <br/>
        /// </param>
        public Repo(FishyFlip.Models.ATDid did = default, string head = default, string rev = default, bool? active = default, string? status = default)
        {
            this.Did = did;
            this.Head = head;
            this.Rev = rev;
            this.Active = active;
            this.Status = status;
            this.Type = "com.atproto.sync.listRepos#repo";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Repo"/> class.
        /// </summary>
        public Repo()
        {
            this.Type = "com.atproto.sync.listRepos#repo";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Repo"/> class.
        /// </summary>
        public Repo(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["head"] is not null) this.Head = obj["head"].AsString();
            if (obj["rev"] is not null) this.Rev = obj["rev"].AsString();
            if (obj["active"] is not null) this.Active = obj["active"].AsBoolean();
            if (obj["status"] is not null) this.Status = obj["status"].AsString();
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid Did { get; set; }

        /// <summary>
        /// Gets or sets the head.
        /// <br/> Current repo commit CID
        /// </summary>
        [JsonPropertyName("head")]
        [JsonRequired]
        public string Head { get; set; }

        /// <summary>
        /// Gets or sets the rev.
        /// </summary>
        [JsonPropertyName("rev")]
        [JsonRequired]
        public string Rev { get; set; }

        /// <summary>
        /// Gets or sets the active.
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// <br/> If active=false, this optional field indicates a possible reason for why the account is not active. If active=false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted.
        /// <br/> Known Values: <br/>
        /// takendown <br/>
        /// suspended <br/>
        /// deactivated <br/>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        public const string RecordType = "com.atproto.sync.listRepos#repo";

        public static Repo FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Sync.Repo>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Sync.Repo>)SourceGenerationContext.Default.ComAtprotoSyncRepo)!;
        }
    }
}

