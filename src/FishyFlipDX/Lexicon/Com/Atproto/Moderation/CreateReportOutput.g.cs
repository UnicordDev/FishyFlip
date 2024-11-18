// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Moderation
{
    public partial class CreateReportOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReportOutput"/> class.
        /// </summary>
        public CreateReportOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReportOutput"/> class.
        /// </summary>
        public CreateReportOutput(CBORObject obj)
        {
            if (obj["id"] is not null) this.Id = obj["id"].AsInt64Value();
            if (obj["reasonType"] is not null) this.ReasonType = obj["reasonType"].AsString();
            if (obj["reason"] is not null) this.Reason = obj["reason"].AsString();
            if (obj["subject"] is not null) this.Subject = obj["subject"].ToATObject();
            if (obj["reportedBy"] is not null) this.ReportedBy = obj["reportedBy"].ToATDid();
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
        }

        [JsonPropertyName("id")]
        [JsonRequired]
        public long? Id { get; set; }

        [JsonPropertyName("reasonType")]
        [JsonRequired]
        public string? ReasonType { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("subject")]
        [JsonRequired]
        public ATObject? Subject { get; set; }

        [JsonPropertyName("reportedBy")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? ReportedBy { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonRequired]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.moderation.createReport#CreateReportOutput";

        public const string RecordType = "com.atproto.moderation.createReport#CreateReportOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Moderation.CreateReportOutput>(this, (JsonTypeInfo<Com.Atproto.Moderation.CreateReportOutput>)SourceGenerationContext.Default.ComAtprotoModerationCreateReportOutput)!;
        }

        public static CreateReportOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Moderation.CreateReportOutput>(json, (JsonTypeInfo<Com.Atproto.Moderation.CreateReportOutput>)SourceGenerationContext.Default.ComAtprotoModerationCreateReportOutput)!;
        }
    }
}

