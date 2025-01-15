// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    public partial class PutRecordOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutRecordOutput"/> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="cid"></param>
        /// <param name="commit">
        /// <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta"/> (com.atproto.repo.defs#commitMeta)
        /// </param>
        /// <param name="validationStatus">
        /// <br/> Known Values: <br/>
        /// valid <br/>
        /// unknown <br/>
        /// </param>
        public PutRecordOutput(FishyFlip.Models.ATUri uri = default, string cid = default, FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta? commit = default, string? validationStatus = default)
        {
            this.Uri = uri;
            this.Cid = cid;
            this.Commit = commit;
            this.ValidationStatus = validationStatus;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PutRecordOutput"/> class.
        /// </summary>
        public PutRecordOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PutRecordOutput"/> class.
        /// </summary>
        public PutRecordOutput(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["commit"] is not null) this.Commit = new FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta(obj["commit"]);
            if (obj["validationStatus"] is not null) this.ValidationStatus = obj["validationStatus"].AsString();
        }

        /// <summary>
        /// Gets or sets the uri.
        /// </summary>
        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri Uri { get; set; }

        /// <summary>
        /// Gets or sets the cid.
        /// </summary>
        [JsonPropertyName("cid")]
        [JsonRequired]
        public string Cid { get; set; }

        /// <summary>
        /// Gets or sets the commit.
        /// <br/> <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta"/> (com.atproto.repo.defs#commitMeta)
        /// </summary>
        [JsonPropertyName("commit")]
        public FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta? Commit { get; set; }

        /// <summary>
        /// Gets or sets the validationStatus.
        /// <br/> Known Values: <br/>
        /// valid <br/>
        /// unknown <br/>
        /// </summary>
        [JsonPropertyName("validationStatus")]
        public string? ValidationStatus { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.repo.putRecord#PutRecordOutput";

        public const string RecordType = "com.atproto.repo.putRecord#PutRecordOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Com.Atproto.Repo.PutRecordOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Repo.PutRecordOutput>)SourceGenerationContext.Default.ComAtprotoRepoPutRecordOutput)!;
        }

        public static PutRecordOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Repo.PutRecordOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Repo.PutRecordOutput>)SourceGenerationContext.Default.ComAtprotoRepoPutRecordOutput)!;
        }
    }
}

