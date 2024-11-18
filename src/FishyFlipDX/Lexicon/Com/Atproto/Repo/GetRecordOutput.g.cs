// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    public partial class GetRecordOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecordOutput"/> class.
        /// </summary>
        public GetRecordOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecordOutput"/> class.
        /// </summary>
        public GetRecordOutput(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["value"] is not null) this.Value = obj["value"].ToATObject();
        }

        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Uri { get; set; }

        [JsonPropertyName("cid")]
        public string? Cid { get; set; }

        [JsonPropertyName("value")]
        [JsonRequired]
        public ATObject? Value { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.repo.getRecord#GetRecordOutput";

        public const string RecordType = "com.atproto.repo.getRecord#GetRecordOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Repo.GetRecordOutput>(this, (JsonTypeInfo<Com.Atproto.Repo.GetRecordOutput>)SourceGenerationContext.Default.ComAtprotoRepoGetRecordOutput)!;
        }

        public static GetRecordOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Repo.GetRecordOutput>(json, (JsonTypeInfo<Com.Atproto.Repo.GetRecordOutput>)SourceGenerationContext.Default.ComAtprotoRepoGetRecordOutput)!;
        }
    }
}

