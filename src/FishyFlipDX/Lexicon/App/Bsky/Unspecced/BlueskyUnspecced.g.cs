// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Unspecced
{

    /// <summary>
    /// app.bsky.unspecced Endpoint Class.
    /// </summary>
    public sealed class BlueskyUnspecced
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueskyUnspecced"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal BlueskyUnspecced(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Get miscellaneous runtime configuration.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Unspecced.GetConfigOutput?>> GetConfigAsync (CancellationToken cancellationToken = default)
        {
            return atp.GetConfigAsync(cancellationToken);
        }


        /// <summary>
        /// An unspecced view of globally popular feed generators.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Unspecced.GetPopularFeedGeneratorsOutput?>> GetPopularFeedGeneratorsAsync (int? limit = 50, string? cursor = default, string? query = default, CancellationToken cancellationToken = default)
        {
            return atp.GetPopularFeedGeneratorsAsync(limit, cursor, query, cancellationToken);
        }


        /// <summary>
        /// Get a skeleton of suggested actors. Intended to be called and then hydrated through app.bsky.actor.getSuggestions
        /// </summary>
        /// <param name="viewer"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="relativeToDid"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Unspecced.GetSuggestionsSkeletonOutput?>> GetSuggestionsSkeletonAsync (FishyFlip.Models.ATDid? viewer = default, int? limit = 50, string? cursor = default, FishyFlip.Models.ATDid? relativeToDid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetSuggestionsSkeletonAsync(viewer, limit, cursor, relativeToDid, cancellationToken);
        }


        /// <summary>
        /// Get a list of suggestions (feeds and users) tagged with categories
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Unspecced.GetTaggedSuggestionsOutput?>> GetTaggedSuggestionsAsync (CancellationToken cancellationToken = default)
        {
            return atp.GetTaggedSuggestionsAsync(cancellationToken);
        }


        /// <summary>
        /// Backend Actors (profile) search, returns only skeleton.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="viewer"></param>
        /// <param name="typeahead"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Unspecced.SearchActorsSkeletonOutput?>> SearchActorsSkeletonAsync (string q, FishyFlip.Models.ATDid? viewer = default, bool? typeahead = default, int? limit = 25, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.SearchActorsSkeletonAsync(q, viewer, typeahead, limit, cursor, cancellationToken);
        }


        /// <summary>
        /// Backend Posts search, returns only skeleton
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="mentions"></param>
        /// <param name="author"></param>
        /// <param name="lang"></param>
        /// <param name="domain"></param>
        /// <param name="url"></param>
        /// <param name="tag"></param>
        /// <param name="viewer"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Unspecced.SearchPostsSkeletonOutput?>> SearchPostsSkeletonAsync (string q, string? sort = default, string? since = default, string? until = default, FishyFlip.Models.ATIdentifier? mentions = default, FishyFlip.Models.ATIdentifier? author = default, string? lang = default, string? domain = default, string? url = default, List<string>? tag = default, FishyFlip.Models.ATDid? viewer = default, int? limit = 25, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.SearchPostsSkeletonAsync(q, sort, since, until, mentions, author, lang, domain, url, tag, viewer, limit, cursor, cancellationToken);
        }


        /// <summary>
        /// Backend Starter Pack search, returns only skeleton.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="viewer"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Unspecced.SearchStarterPacksSkeletonOutput?>> SearchStarterPacksSkeletonAsync (string q, FishyFlip.Models.ATDid? viewer = default, int? limit = 25, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.SearchStarterPacksSkeletonAsync(q, viewer, limit, cursor, cancellationToken);
        }

    }
}

