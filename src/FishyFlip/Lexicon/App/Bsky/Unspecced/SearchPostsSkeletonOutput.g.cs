// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Unspecced
{
    public partial class SearchPostsSkeletonOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPostsSkeletonOutput"/> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="hitsTotal">Count of search hits. Optional, may be rounded/truncated, and may not be possible to paginate through all hits.</param>
        /// <param name="posts"></param>
        public SearchPostsSkeletonOutput(string? cursor = default, long? hitsTotal = default, List<FishyFlip.Lexicon.App.Bsky.Unspecced.SkeletonSearchPost> posts = default)
        {
            this.Cursor = cursor;
            this.HitsTotal = hitsTotal;
            this.Posts = posts;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPostsSkeletonOutput"/> class.
        /// </summary>
        public SearchPostsSkeletonOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPostsSkeletonOutput"/> class.
        /// </summary>
        public SearchPostsSkeletonOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["hitsTotal"] is not null) this.HitsTotal = obj["hitsTotal"].AsInt64Value();
            if (obj["posts"] is not null) this.Posts = obj["posts"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Unspecced.SkeletonSearchPost(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets the hitsTotal.
        /// <br/> Count of search hits. Optional, may be rounded/truncated, and may not be possible to paginate through all hits.
        /// </summary>
        [JsonPropertyName("hitsTotal")]
        public long? HitsTotal { get; set; }

        /// <summary>
        /// Gets or sets the posts.
        /// </summary>
        [JsonPropertyName("posts")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.App.Bsky.Unspecced.SkeletonSearchPost> Posts { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.unspecced.searchPostsSkeleton#SearchPostsSkeletonOutput";

        public const string RecordType = "app.bsky.unspecced.searchPostsSkeleton#SearchPostsSkeletonOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Unspecced.SearchPostsSkeletonOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Unspecced.SearchPostsSkeletonOutput>)SourceGenerationContext.Default.AppBskyUnspeccedSearchPostsSkeletonOutput)!;
        }

        public static SearchPostsSkeletonOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Unspecced.SearchPostsSkeletonOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Unspecced.SearchPostsSkeletonOutput>)SourceGenerationContext.Default.AppBskyUnspeccedSearchPostsSkeletonOutput)!;
        }
    }
}

