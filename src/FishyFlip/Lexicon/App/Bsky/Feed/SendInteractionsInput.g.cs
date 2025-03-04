// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class SendInteractionsInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SendInteractionsInput"/> class.
        /// </summary>
        /// <param name="interactions"></param>
        public SendInteractionsInput(List<FishyFlip.Lexicon.App.Bsky.Feed.Interaction> interactions = default)
        {
            this.Interactions = interactions;
            this.Type = "app.bsky.feed.sendInteractions#SendInteractionsInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendInteractionsInput"/> class.
        /// </summary>
        public SendInteractionsInput()
        {
            this.Type = "app.bsky.feed.sendInteractions#SendInteractionsInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendInteractionsInput"/> class.
        /// </summary>
        public SendInteractionsInput(CBORObject obj)
        {
            if (obj["interactions"] is not null) this.Interactions = obj["interactions"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Feed.Interaction(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the interactions.
        /// </summary>
        [JsonPropertyName("interactions")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.App.Bsky.Feed.Interaction> Interactions { get; set; }

        public const string RecordType = "app.bsky.feed.sendInteractions#SendInteractionsInput";

        public static SendInteractionsInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.SendInteractionsInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.SendInteractionsInput>)SourceGenerationContext.Default.AppBskyFeedSendInteractionsInput)!;
        }
    }
}

