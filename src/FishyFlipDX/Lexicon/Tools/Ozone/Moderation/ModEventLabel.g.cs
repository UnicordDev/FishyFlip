// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    /// <summary>
    /// Apply/Negate labels on a subject
    /// </summary>
    public partial class ModEventLabel : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventLabel"/> class.
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="createLabelVals"></param>
        /// <param name="negateLabelVals"></param>
        public ModEventLabel(string? comment = default, List<string>? createLabelVals = default, List<string>? negateLabelVals = default)
        {
            this.Comment = comment;
            this.CreateLabelVals = createLabelVals;
            this.NegateLabelVals = negateLabelVals;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventLabel"/> class.
        /// </summary>
        public ModEventLabel()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventLabel"/> class.
        /// </summary>
        public ModEventLabel(CBORObject obj)
        {
            if (obj["comment"] is not null) this.Comment = obj["comment"].AsString();
            if (obj["createLabelVals"] is not null) this.CreateLabelVals = obj["createLabelVals"].Values.Select(n =>n.AsString()).ToList();
            if (obj["negateLabelVals"] is not null) this.NegateLabelVals = obj["negateLabelVals"].Values.Select(n =>n.AsString()).ToList();
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Gets or sets the createLabelVals.
        /// </summary>
        [JsonPropertyName("createLabelVals")]
        [JsonRequired]
        public List<string>? CreateLabelVals { get; set; }

        /// <summary>
        /// Gets or sets the negateLabelVals.
        /// </summary>
        [JsonPropertyName("negateLabelVals")]
        [JsonRequired]
        public List<string>? NegateLabelVals { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.defs#modEventLabel";

        public const string RecordType = "tools.ozone.moderation.defs#modEventLabel";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Tools.Ozone.Moderation.ModEventLabel>(this, (JsonTypeInfo<Tools.Ozone.Moderation.ModEventLabel>)SourceGenerationContext.Default.ToolsOzoneModerationModEventLabel)!;
        }

        public static ModEventLabel FromJson(string json)
        {
            return JsonSerializer.Deserialize<Tools.Ozone.Moderation.ModEventLabel>(json, (JsonTypeInfo<Tools.Ozone.Moderation.ModEventLabel>)SourceGenerationContext.Default.ToolsOzoneModerationModEventLabel)!;
        }
    }
}

