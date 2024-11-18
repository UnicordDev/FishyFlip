// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Feed
{

    /// <summary>
    /// app.bsky.feed Endpoint Group.
    /// </summary>
    public static class FeedEndpoints
    {

       public const string DescribeFeedGenerator = "/xrpc/app.bsky.feed.describeFeedGenerator";

       public const string GetActorFeeds = "/xrpc/app.bsky.feed.getActorFeeds";

       public const string GetActorLikes = "/xrpc/app.bsky.feed.getActorLikes";

       public const string GetAuthorFeed = "/xrpc/app.bsky.feed.getAuthorFeed";

       public const string GetFeed = "/xrpc/app.bsky.feed.getFeed";

       public const string GetFeedGenerator = "/xrpc/app.bsky.feed.getFeedGenerator";

       public const string GetFeedGenerators = "/xrpc/app.bsky.feed.getFeedGenerators";

       public const string GetFeedSkeleton = "/xrpc/app.bsky.feed.getFeedSkeleton";

       public const string GetLikes = "/xrpc/app.bsky.feed.getLikes";

       public const string GetListFeed = "/xrpc/app.bsky.feed.getListFeed";

       public const string GetPosts = "/xrpc/app.bsky.feed.getPosts";

       public const string GetPostThread = "/xrpc/app.bsky.feed.getPostThread";

       public const string GetQuotes = "/xrpc/app.bsky.feed.getQuotes";

       public const string GetRepostedBy = "/xrpc/app.bsky.feed.getRepostedBy";

       public const string GetSuggestedFeeds = "/xrpc/app.bsky.feed.getSuggestedFeeds";

       public const string GetTimeline = "/xrpc/app.bsky.feed.getTimeline";

       public const string SearchPosts = "/xrpc/app.bsky.feed.searchPosts";

       public const string SendInteractions = "/xrpc/app.bsky.feed.sendInteractions";


        /// <summary>
        /// Get information about a feed generator, including policies and offered feed URIs. Does not require auth; implemented by Feed Generator services (not App View).
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.DescribeFeedGeneratorOutput>> DescribeFeedGeneratorAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a list of feeds (feed generator records) created by the actor (in the actor's repo).
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetActorFeedsOutput>> GetActorFeedsAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier actor, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a list of posts liked by an actor. Requires auth, actor must be the requesting account.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetActorLikesOutput>> GetActorLikesAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier actor, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a view of an actor's 'author feed' (post and reposts by the author). Does not require auth.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetAuthorFeedOutput>> GetAuthorFeedAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier actor, int? limit = 50, string? cursor = default, string? filter = default, bool? includePins = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a hydrated feed from an actor's selected feed generator. Implemented by App View.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedOutput>> GetFeedAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri feed, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get information about a feed generator. Implemented by AppView.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedGeneratorOutput>> GetFeedGeneratorAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri feed, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get information about a list of feed generators.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedGeneratorsOutput>> GetFeedGeneratorsAsync (this FishyFlip.ATProtocol atp, List<FishyFlip.Models.ATUri> feeds, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a skeleton of a feed provided by a feed generator. Auth is optional, depending on provider requirements, and provides the DID of the requester. Implemented by Feed Generator Service.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetFeedSkeletonOutput>> GetFeedSkeletonAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri feed, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get like records which reference a subject (by AT-URI and CID).
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetLikesOutput>> GetLikesAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri uri, string? cid = default, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a feed of recent posts from a list (posts and reposts from any actors on the list). Does not require auth.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetListFeedOutput>> GetListFeedAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri list, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets post views for a specified list of posts (by AT-URI). This is sometimes referred to as 'hydrating' a 'feed skeleton'.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetPostsOutput>> GetPostsAsync (this FishyFlip.ATProtocol atp, List<FishyFlip.Models.ATUri> uris, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get posts in a thread. Does not require auth, but additional metadata and filtering will be applied for authed requests.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetPostThreadOutput>> GetPostThreadAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri uri, int? depth = 6, int? parentHeight = 80, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a list of quotes for a given post.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetQuotesOutput>> GetQuotesAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri uri, string? cid = default, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a list of reposts for a given post.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetRepostedByOutput>> GetRepostedByAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATUri uri, string? cid = default, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a list of suggested feeds (feed generators) for the requesting account.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetSuggestedFeedsOutput>> GetSuggestedFeedsAsync (this FishyFlip.ATProtocol atp, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get a view of the requesting account's home timeline. This is expected to be some form of reverse-chronological feed.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.GetTimelineOutput>> GetTimelineAsync (this FishyFlip.ATProtocol atp, string? algorithm = default, int? limit = 50, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Find posts matching search criteria, returning views of those posts.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.SearchPostsOutput>> SearchPostsAsync (this FishyFlip.ATProtocol atp, string q, string? sort = default, string? since = default, string? until = default, FishyFlip.Models.ATIdentifier? mentions = default, FishyFlip.Models.ATIdentifier? author = default, string? lang = default, string? domain = default, string? url = default, List<string>? tag = default, int? limit = 25, string? cursor = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Send information about interactions with feed items back to the feed generator that served them.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.App.Bsky.Feed.SendInteractionsOutput>> SendInteractionsAsync (this FishyFlip.ATProtocol atp, List<ATObject> interactions, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

    }
}

