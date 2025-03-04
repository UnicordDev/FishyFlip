// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    /// <summary>
    /// Allow replies from actors you follow.
    /// </summary>
    public partial class FollowingRule : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowingRule"/> class.
        /// </summary>
        public FollowingRule()
        {
            this.Type = "app.bsky.feed.threadgate#followingRule";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="FollowingRule"/> class.
        /// </summary>
        public FollowingRule(CBORObject obj)
        {
        }

        public const string RecordType = "app.bsky.feed.threadgate#followingRule";

        public static FollowingRule FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.FollowingRule>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.FollowingRule>)SourceGenerationContext.Default.AppBskyFeedFollowingRule)!;
        }
    }
}

