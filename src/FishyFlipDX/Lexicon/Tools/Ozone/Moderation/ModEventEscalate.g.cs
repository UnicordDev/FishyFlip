// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    public partial class ModEventEscalate : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventEscalate"/> class.
        /// </summary>
        /// <param name="comment"></param>
        public ModEventEscalate(string? comment = default)
        {
            this.Comment = comment;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventEscalate"/> class.
        /// </summary>
        public ModEventEscalate()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventEscalate"/> class.
        /// </summary>
        public ModEventEscalate(CBORObject obj)
        {
            if (obj["comment"] is not null) this.Comment = obj["comment"].AsString();
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.defs#modEventEscalate";

        public const string RecordType = "tools.ozone.moderation.defs#modEventEscalate";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Moderation.ModEventEscalate>(this, (JsonTypeInfo<Tools.Ozone.Moderation.ModEventEscalate>)SourceGenerationContext.Default.ToolsOzoneModerationModEventEscalate)!;
        }

        public static ModEventEscalate FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Moderation.ModEventEscalate>(json, (JsonTypeInfo<Tools.Ozone.Moderation.ModEventEscalate>)SourceGenerationContext.Default.ToolsOzoneModerationModEventEscalate)!;
        }
    }
}

