// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class LabelerPrefItem : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerPrefItem"/> class.
        /// </summary>
        /// <param name="did"></param>
        public LabelerPrefItem(FishyFlip.Models.ATDid did = default)
        {
            this.Did = did;
            this.Type = "app.bsky.actor.defs#labelerPrefItem";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerPrefItem"/> class.
        /// </summary>
        public LabelerPrefItem()
        {
            this.Type = "app.bsky.actor.defs#labelerPrefItem";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="LabelerPrefItem"/> class.
        /// </summary>
        public LabelerPrefItem(CBORObject obj)
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

        public const string RecordType = "app.bsky.actor.defs#labelerPrefItem";

        public static LabelerPrefItem FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.LabelerPrefItem>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.LabelerPrefItem>)SourceGenerationContext.Default.AppBskyActorLabelerPrefItem)!;
        }
    }
}

