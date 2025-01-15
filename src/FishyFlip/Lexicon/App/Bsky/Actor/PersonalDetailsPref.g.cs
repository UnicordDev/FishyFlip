// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class PersonalDetailsPref : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalDetailsPref"/> class.
        /// </summary>
        /// <param name="birthDate">The birth date of account owner.</param>
        public PersonalDetailsPref(DateTime? birthDate = default)
        {
            this.BirthDate = birthDate;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalDetailsPref"/> class.
        /// </summary>
        public PersonalDetailsPref()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalDetailsPref"/> class.
        /// </summary>
        public PersonalDetailsPref(CBORObject obj)
        {
            if (obj["birthDate"] is not null) this.BirthDate = obj["birthDate"].ToDateTime();
        }

        /// <summary>
        /// Gets or sets the birthDate.
        /// <br/> The birth date of account owner.
        /// </summary>
        [JsonPropertyName("birthDate")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#personalDetailsPref";

        public const string RecordType = "app.bsky.actor.defs#personalDetailsPref";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Actor.PersonalDetailsPref>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.PersonalDetailsPref>)SourceGenerationContext.Default.AppBskyActorPersonalDetailsPref)!;
        }

        public static PersonalDetailsPref FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.PersonalDetailsPref>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.PersonalDetailsPref>)SourceGenerationContext.Default.AppBskyActorPersonalDetailsPref)!;
        }
    }
}

