// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class SendInteractionsInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SendInteractionsInput"/> class.
        /// </summary>
        public SendInteractionsInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendInteractionsInput"/> class.
        /// </summary>
        public SendInteractionsInput(CBORObject obj)
        {
            if (obj["interactions"] is not null) this.Interactions = obj["interactions"].Values.Select(n => n is not null ? new App.Bsky.Feed.Interaction(n) : null).ToList();
        }

        [JsonPropertyName("interactions")]
        [JsonRequired]
        public List<App.Bsky.Feed.Interaction?>? Interactions { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.sendInteractions#SendInteractionsInput";

        public const string RecordType = "app.bsky.feed.sendInteractions#SendInteractionsInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Feed.SendInteractionsInput>(this, (JsonTypeInfo<App.Bsky.Feed.SendInteractionsInput>)SourceGenerationContext.Default.AppBskyFeedSendInteractionsInput)!;
        }

        public static SendInteractionsInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Feed.SendInteractionsInput>(json, (JsonTypeInfo<App.Bsky.Feed.SendInteractionsInput>)SourceGenerationContext.Default.AppBskyFeedSendInteractionsInput)!;
        }
    }
}

