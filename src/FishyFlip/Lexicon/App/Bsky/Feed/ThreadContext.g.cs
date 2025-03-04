// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    /// <summary>
    /// Metadata about this post within the context of the thread it is in.
    /// </summary>
    public partial class ThreadContext : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadContext"/> class.
        /// </summary>
        /// <param name="rootAuthorLike"></param>
        public ThreadContext(FishyFlip.Models.ATUri? rootAuthorLike = default)
        {
            this.RootAuthorLike = rootAuthorLike;
            this.Type = "app.bsky.feed.defs#threadContext";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadContext"/> class.
        /// </summary>
        public ThreadContext()
        {
            this.Type = "app.bsky.feed.defs#threadContext";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadContext"/> class.
        /// </summary>
        public ThreadContext(CBORObject obj)
        {
            if (obj["rootAuthorLike"] is not null) this.RootAuthorLike = obj["rootAuthorLike"].ToATUri();
        }

        /// <summary>
        /// Gets or sets the rootAuthorLike.
        /// </summary>
        [JsonPropertyName("rootAuthorLike")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? RootAuthorLike { get; set; }

        public const string RecordType = "app.bsky.feed.defs#threadContext";

        public static ThreadContext FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.ThreadContext>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.ThreadContext>)SourceGenerationContext.Default.AppBskyFeedThreadContext)!;
        }
    }
}

