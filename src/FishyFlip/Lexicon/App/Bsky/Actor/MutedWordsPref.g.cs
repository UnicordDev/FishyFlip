// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class MutedWordsPref : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MutedWordsPref"/> class.
        /// </summary>
        /// <param name="items">A list of words the account owner has muted.</param>
        public MutedWordsPref(List<FishyFlip.Lexicon.App.Bsky.Actor.MutedWord> items = default)
        {
            this.Items = items;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MutedWordsPref"/> class.
        /// </summary>
        public MutedWordsPref()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MutedWordsPref"/> class.
        /// </summary>
        public MutedWordsPref(CBORObject obj)
        {
            if (obj["items"] is not null) this.Items = obj["items"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Actor.MutedWord(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the items.
        /// <br/> A list of words the account owner has muted.
        /// </summary>
        [JsonPropertyName("items")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.App.Bsky.Actor.MutedWord> Items { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#mutedWordsPref";

        public const string RecordType = "app.bsky.actor.defs#mutedWordsPref";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Actor.MutedWordsPref>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.MutedWordsPref>)SourceGenerationContext.Default.AppBskyActorMutedWordsPref)!;
        }

        public static MutedWordsPref FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.MutedWordsPref>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.MutedWordsPref>)SourceGenerationContext.Default.AppBskyActorMutedWordsPref)!;
        }
    }
}

