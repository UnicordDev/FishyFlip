// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class AdultContentPref : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AdultContentPref"/> class.
        /// </summary>
        /// <param name="enabled"></param>
        public AdultContentPref(bool enabled = default)
        {
            this.Enabled = enabled;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AdultContentPref"/> class.
        /// </summary>
        public AdultContentPref()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="AdultContentPref"/> class.
        /// </summary>
        public AdultContentPref(CBORObject obj)
        {
            if (obj["enabled"] is not null) this.Enabled = obj["enabled"].AsBoolean();
        }

        /// <summary>
        /// Gets or sets the enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        [JsonRequired]
        public bool Enabled { get; set; } = false;

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#adultContentPref";

        public const string RecordType = "app.bsky.actor.defs#adultContentPref";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Actor.AdultContentPref>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.AdultContentPref>)SourceGenerationContext.Default.AppBskyActorAdultContentPref)!;
        }

        public static AdultContentPref FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.AdultContentPref>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.AdultContentPref>)SourceGenerationContext.Default.AppBskyActorAdultContentPref)!;
        }
    }
}

