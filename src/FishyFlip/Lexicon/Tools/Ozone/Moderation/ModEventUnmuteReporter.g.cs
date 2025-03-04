// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    /// <summary>
    /// Unmute incoming reports from an account
    /// </summary>
    public partial class ModEventUnmuteReporter : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventUnmuteReporter"/> class.
        /// </summary>
        /// <param name="comment">Describe reasoning behind the reversal.</param>
        public ModEventUnmuteReporter(string? comment = default)
        {
            this.Comment = comment;
            this.Type = "tools.ozone.moderation.defs#modEventUnmuteReporter";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventUnmuteReporter"/> class.
        /// </summary>
        public ModEventUnmuteReporter()
        {
            this.Type = "tools.ozone.moderation.defs#modEventUnmuteReporter";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventUnmuteReporter"/> class.
        /// </summary>
        public ModEventUnmuteReporter(CBORObject obj)
        {
            if (obj["comment"] is not null) this.Comment = obj["comment"].AsString();
        }

        /// <summary>
        /// Gets or sets the comment.
        /// <br/> Describe reasoning behind the reversal.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        public const string RecordType = "tools.ozone.moderation.defs#modEventUnmuteReporter";

        public static ModEventUnmuteReporter FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Tools.Ozone.Moderation.ModEventUnmuteReporter>(json, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Moderation.ModEventUnmuteReporter>)SourceGenerationContext.Default.ToolsOzoneModerationModEventUnmuteReporter)!;
        }
    }
}

