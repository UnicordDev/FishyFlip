// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    public partial class UpdateResult : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult"/> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="cid"></param>
        /// <param name="validationStatus">
        /// Known Values:
        /// valid
        /// unknown
        /// </param>
        public UpdateResult(FishyFlip.Models.ATUri? uri = default, string? cid = default, string? validationStatus = default)
        {
            this.Uri = uri;
            this.Cid = cid;
            this.ValidationStatus = validationStatus;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult"/> class.
        /// </summary>
        public UpdateResult()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResult"/> class.
        /// </summary>
        public UpdateResult(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["validationStatus"] is not null) this.ValidationStatus = obj["validationStatus"].AsString();
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
        /// Gets or sets the validationStatus.
        /// Known Values:
        /// valid
        /// unknown
        /// </summary>
        [JsonPropertyName("validationStatus")]
        public string? ValidationStatus { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.repo.applyWrites#updateResult";

        public const string RecordType = "com.atproto.repo.applyWrites#updateResult";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Repo.UpdateResult>(this, (JsonTypeInfo<Com.Atproto.Repo.UpdateResult>)SourceGenerationContext.Default.ComAtprotoRepoUpdateResult)!;
        }

        public static UpdateResult FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Repo.UpdateResult>(json, (JsonTypeInfo<Com.Atproto.Repo.UpdateResult>)SourceGenerationContext.Default.ComAtprotoRepoUpdateResult)!;
        }
    }
}

