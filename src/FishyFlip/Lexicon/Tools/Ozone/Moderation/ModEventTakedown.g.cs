// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    /// <summary>
    /// Take down a subject permanently or temporarily
    /// </summary>
    public partial class ModEventTakedown : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventTakedown"/> class.
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="durationInHours">Indicates how long the takedown should be in effect before automatically expiring.</param>
        /// <param name="acknowledgeAccountSubjects">If true, all other reports on content authored by this account will be resolved (acknowledged).</param>
        /// <param name="policies">Names/Keywords of the policies that drove the decision.</param>
        public ModEventTakedown(string? comment = default, long? durationInHours = default, bool? acknowledgeAccountSubjects = default, List<string>? policies = default)
        {
            this.Comment = comment;
            this.DurationInHours = durationInHours;
            this.AcknowledgeAccountSubjects = acknowledgeAccountSubjects;
            this.Policies = policies;
            this.Type = "tools.ozone.moderation.defs#modEventTakedown";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventTakedown"/> class.
        /// </summary>
        public ModEventTakedown()
        {
            this.Type = "tools.ozone.moderation.defs#modEventTakedown";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModEventTakedown"/> class.
        /// </summary>
        public ModEventTakedown(CBORObject obj)
        {
            if (obj["comment"] is not null) this.Comment = obj["comment"].AsString();
            if (obj["durationInHours"] is not null) this.DurationInHours = obj["durationInHours"].AsInt64Value();
            if (obj["acknowledgeAccountSubjects"] is not null) this.AcknowledgeAccountSubjects = obj["acknowledgeAccountSubjects"].AsBoolean();
            if (obj["policies"] is not null) this.Policies = obj["policies"].Values.Select(n =>n.AsString()).ToList();
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Gets or sets the durationInHours.
        /// <br/> Indicates how long the takedown should be in effect before automatically expiring.
        /// </summary>
        [JsonPropertyName("durationInHours")]
        public long? DurationInHours { get; set; }

        /// <summary>
        /// Gets or sets the acknowledgeAccountSubjects.
        /// <br/> If true, all other reports on content authored by this account will be resolved (acknowledged).
        /// </summary>
        [JsonPropertyName("acknowledgeAccountSubjects")]
        public bool? AcknowledgeAccountSubjects { get; set; }

        /// <summary>
        /// Gets or sets the policies.
        /// <br/> Names/Keywords of the policies that drove the decision.
        /// </summary>
        [JsonPropertyName("policies")]
        public List<string>? Policies { get; set; }

        public const string RecordType = "tools.ozone.moderation.defs#modEventTakedown";

        public static ModEventTakedown FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Tools.Ozone.Moderation.ModEventTakedown>(json, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Moderation.ModEventTakedown>)SourceGenerationContext.Default.ToolsOzoneModerationModEventTakedown)!;
        }
    }
}

