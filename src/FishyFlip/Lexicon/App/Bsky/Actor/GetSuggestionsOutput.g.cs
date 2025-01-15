// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class GetSuggestionsOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSuggestionsOutput"/> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="actors"></param>
        /// <param name="recId">Snowflake for this recommendation, use when submitting recommendation events.</param>
        public GetSuggestionsOutput(string? cursor = default, List<FishyFlip.Lexicon.App.Bsky.Actor.ProfileView>? actors = default, long? recId = default)
        {
            this.Cursor = cursor;
            this.Actors = actors;
            this.RecId = recId;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetSuggestionsOutput"/> class.
        /// </summary>
        public GetSuggestionsOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetSuggestionsOutput"/> class.
        /// </summary>
        public GetSuggestionsOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["actors"] is not null) this.Actors = obj["actors"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Actor.ProfileView(n)).ToList();
            if (obj["recId"] is not null) this.RecId = obj["recId"].AsInt64Value();
        }

        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets the actors.
        /// </summary>
        [JsonPropertyName("actors")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.App.Bsky.Actor.ProfileView>? Actors { get; set; }

        /// <summary>
        /// Gets or sets the recId.
        /// <br/> Snowflake for this recommendation, use when submitting recommendation events.
        /// </summary>
        [JsonPropertyName("recId")]
        public long? RecId { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.getSuggestions#GetSuggestionsOutput";

        public const string RecordType = "app.bsky.actor.getSuggestions#GetSuggestionsOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Actor.GetSuggestionsOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.GetSuggestionsOutput>)SourceGenerationContext.Default.AppBskyActorGetSuggestionsOutput)!;
        }

        public static GetSuggestionsOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.GetSuggestionsOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.GetSuggestionsOutput>)SourceGenerationContext.Default.AppBskyActorGetSuggestionsOutput)!;
        }
    }
}

