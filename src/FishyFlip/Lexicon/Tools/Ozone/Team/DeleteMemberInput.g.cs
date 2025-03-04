// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Tools.Ozone.Team
{
    public partial class DeleteMemberInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemberInput"/> class.
        /// </summary>
        /// <param name="did"></param>
        public DeleteMemberInput(FishyFlip.Models.ATDid did = default)
        {
            this.Did = did;
            this.Type = "tools.ozone.team.deleteMember#DeleteMemberInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemberInput"/> class.
        /// </summary>
        public DeleteMemberInput()
        {
            this.Type = "tools.ozone.team.deleteMember#DeleteMemberInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemberInput"/> class.
        /// </summary>
        public DeleteMemberInput(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid Did { get; set; }

        public const string RecordType = "tools.ozone.team.deleteMember#DeleteMemberInput";

        public static DeleteMemberInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Tools.Ozone.Team.DeleteMemberInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Team.DeleteMemberInput>)SourceGenerationContext.Default.ToolsOzoneTeamDeleteMemberInput)!;
        }
    }
}

