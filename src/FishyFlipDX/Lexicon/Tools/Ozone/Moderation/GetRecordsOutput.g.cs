// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    public partial class GetRecordsOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecordsOutput"/> class.
        /// </summary>
        public GetRecordsOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecordsOutput"/> class.
        /// </summary>
        public GetRecordsOutput(CBORObject obj)
        {
            if (obj["records"] is not null) this.Records = obj["records"].Values.Select(n => n is not null ? n.ToATObject() : null).ToList();
        }

        [JsonPropertyName("records")]
        [JsonRequired]
        public List<ATObject?>? Records { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.getRecords#GetRecordsOutput";

        public const string RecordType = "tools.ozone.moderation.getRecords#GetRecordsOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Moderation.GetRecordsOutput>(this, (JsonTypeInfo<Tools.Ozone.Moderation.GetRecordsOutput>)SourceGenerationContext.Default.ToolsOzoneModerationGetRecordsOutput)!;
        }

        public static GetRecordsOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Moderation.GetRecordsOutput>(json, (JsonTypeInfo<Tools.Ozone.Moderation.GetRecordsOutput>)SourceGenerationContext.Default.ToolsOzoneModerationGetRecordsOutput)!;
        }
    }
}

