// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Feed
{
    /// <summary>
    /// Record defining interaction gating rules for a thread (aka, reply controls). The record key (rkey) of the threadgate record must match the record key of the thread's root post, and that record must be in the same repository.
    /// </summary>
    public partial class Threadgate : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Threadgate"/> class.
        /// </summary>
        /// <param name="post">Reference (AT-URI) to the post record.</param>
        /// <param name="allow">
        /// <br/> Union Types: <br/>
        /// #mentionRule <br/>
        /// #followingRule <br/>
        /// #listRule <br/>
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="hiddenReplies">List of hidden reply URIs.</param>
        public Threadgate(FishyFlip.Models.ATUri? post, List<ATObject>? allow = default, DateTime? createdAt = default, List<FishyFlip.Models.ATUri>? hiddenReplies = default)
        {
            this.Post = post;
            this.Allow = allow;
            this.CreatedAt = createdAt ?? DateTime.UtcNow;
            this.HiddenReplies = hiddenReplies;
            this.Type = "app.bsky.feed.threadgate";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Threadgate"/> class.
        /// </summary>
        public Threadgate()
        {
            this.Type = "app.bsky.feed.threadgate";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Threadgate"/> class.
        /// </summary>
        public Threadgate(CBORObject obj)
        {
            if (obj["post"] is not null) this.Post = obj["post"].ToATUri();
            if (obj["allow"] is not null) this.Allow = obj["allow"].Values.Select(n =>n.ToATObject()).ToList();
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
            if (obj["hiddenReplies"] is not null) this.HiddenReplies = obj["hiddenReplies"].Values.Select(n =>n.ToATUri()!).ToList();
        }

        /// <summary>
        /// Gets or sets the post.
        /// <br/> Reference (AT-URI) to the post record.
        /// </summary>
        [JsonPropertyName("post")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? Post { get; set; }

        /// <summary>
        /// Gets or sets the allow.
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.MentionRule"/> (app.bsky.feed.threadgate#mentionRule) <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.FollowingRule"/> (app.bsky.feed.threadgate#followingRule) <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Feed.ListRule"/> (app.bsky.feed.threadgate#listRule) <br/>
        /// </summary>
        [JsonPropertyName("allow")]
        public List<ATObject>? Allow { get; set; }

        /// <summary>
        /// Gets or sets the createdAt.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the hiddenReplies.
        /// <br/> List of hidden reply URIs.
        /// </summary>
        [JsonPropertyName("hiddenReplies")]
        public List<FishyFlip.Models.ATUri>? HiddenReplies { get; set; }

        public const string RecordType = "app.bsky.feed.threadgate";

        public static Threadgate FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Feed.Threadgate>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Feed.Threadgate>)SourceGenerationContext.Default.AppBskyFeedThreadgate)!;
        }
    }
}

