// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    public partial class GetFeedSkeletonOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedSkeletonOutput"/> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="feed"></param>
        public GetFeedSkeletonOutput(string? cursor = default, List<FishyFlip.Lexicon.App.Bsky.Feed.SkeletonFeedPost> feed = default)
        {
            this.Cursor = cursor;
            this.Feed = feed;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedSkeletonOutput"/> class.
        /// </summary>
        public GetFeedSkeletonOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetFeedSkeletonOutput"/> class.
        /// </summary>
        public GetFeedSkeletonOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["feed"] is not null) this.Feed = obj["feed"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Feed.SkeletonFeedPost(n)).ToList();
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
        public List<FishyFlip.Lexicon.App.Bsky.Feed.SkeletonFeedPost> Feed { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.feed.getFeedSkeleton#GetFeedSkeletonOutput";

        public const string RecordType = "app.bsky.feed.getFeedSkeleton#GetFeedSkeletonOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedSkeletonOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedSkeletonOutput>)SourceGenerationContext.Default.AppBskyFeedGetFeedSkeletonOutput)!;
        }

        public static GetFeedSkeletonOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedSkeletonOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedSkeletonOutput>)SourceGenerationContext.Default.AppBskyFeedGetFeedSkeletonOutput)!;
        }
    }
}

