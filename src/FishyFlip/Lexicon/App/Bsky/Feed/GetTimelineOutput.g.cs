// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class GetTimelineOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTimelineOutput"/> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="feed"></param>
        public GetTimelineOutput(string? cursor = default, List<FishyFlip.Lexicon.App.Bsky.Feed.FeedViewPost> feed = default)
        {
            this.Cursor = cursor;
            this.Feed = feed;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetTimelineOutput"/> class.
        /// </summary>
        public GetTimelineOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetTimelineOutput"/> class.
        /// </summary>
        public GetTimelineOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["feed"] is not null) this.Feed = obj["feed"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Feed.FeedViewPost(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets the feed.
        /// </summary>
        [JsonPropertyName("feed")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.App.Bsky.Feed.FeedViewPost> Feed { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.getTimeline#GetTimelineOutput";

        public const string RecordType = "app.bsky.feed.getTimeline#GetTimelineOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Feed.GetTimelineOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.GetTimelineOutput>)SourceGenerationContext.Default.AppBskyFeedGetTimelineOutput)!;
        }

        public static GetTimelineOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.GetTimelineOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.GetTimelineOutput>)SourceGenerationContext.Default.AppBskyFeedGetTimelineOutput)!;
        }
    }
}

