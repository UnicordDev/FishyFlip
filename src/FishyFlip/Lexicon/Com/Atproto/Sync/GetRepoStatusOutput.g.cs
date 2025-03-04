// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Sync
{
    public partial class GetRepoStatusOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepoStatusOutput"/> class.
        /// </summary>
        /// <param name="did"></param>
        /// <param name="active"></param>
        /// <param name="status">If active=false, this optional field indicates a possible reason for why the account is not active. If active=false and no status is supplied, then the host makes no claim for why the repository is no longer being hosted.
        /// <br/> Known Values: <br/>
        /// takendown <br/>
        /// suspended <br/>
        /// deactivated <br/>
        /// </param>
        /// <param name="rev">Optional field, the current rev of the repo, if active=true</param>
        public GetRepoStatusOutput(FishyFlip.Models.ATDid did = default, bool active = default, string? status = default, string? rev = default)
        {
            this.Did = did;
            this.Active = active;
            this.Status = status;
            this.Rev = rev;
            this.Type = "com.atproto.sync.getRepoStatus#GetRepoStatusOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepoStatusOutput"/> class.
        /// </summary>
        public GetRepoStatusOutput()
        {
            this.Type = "com.atproto.sync.getRepoStatus#GetRepoStatusOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetRepoStatusOutput"/> class.
        /// </summary>
        public GetRepoStatusOutput(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["active"] is not null) this.Active = obj["active"].AsBoolean();
            if (obj["status"] is not null) this.Status = obj["status"].AsString();
            if (obj["rev"] is not null) this.Rev = obj["rev"].AsString();
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid Did { get; set; }

        /// <summary>
        /// Gets or sets the active.
        /// </summary>
        [JsonPropertyName("active")]
        [JsonRequired]
        public bool Active { get; set; }

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

        /// <summary>
        /// Gets or sets the rev.
        /// <br/> Optional field, the current rev of the repo, if active=true
        /// </summary>
        [JsonPropertyName("rev")]
        public string? Rev { get; set; }

        public const string RecordType = "com.atproto.sync.getRepoStatus#GetRepoStatusOutput";

        public static GetRepoStatusOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Sync.GetRepoStatusOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Sync.GetRepoStatusOutput>)SourceGenerationContext.Default.ComAtprotoSyncGetRepoStatusOutput)!;
        }
    }
}

