// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

using FishyFlip.Lexicon.Com.Atproto.Repo;

namespace FishyFlip.Lexicon.Community.Lexicon.Bookmarks
{

    /// <summary>
    /// Extension methods for community.lexicon.bookmarks.
    /// </summary>
    public static class ATProtoBookmarksExtensions
    {

        /// <summary>
        /// Create a Bookmark record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateBookmarkAsync(this FishyFlip.ATProtocol atp, FishyFlip.Lexicon.Community.Lexicon.Bookmarks.Bookmark record, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "community.lexicon.bookmarks.bookmark", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Create a Bookmark record.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="collection"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateBookmarkAsync(this FishyFlip.ATProtocol atp, string? subject, DateTime? createdAt = default, List<string>? tags = default, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            var record = new FishyFlip.Lexicon.Community.Lexicon.Bookmarks.Bookmark();
            record.Subject = subject;
            record.CreatedAt = createdAt ?? DateTime.UtcNow;
            record.Tags = tags;
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "community.lexicon.bookmarks.bookmark", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Delete a Bookmark record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<DeleteRecordOutput?>> DeleteBookmarkAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.DeleteRecordAsync(repo, "community.lexicon.bookmarks.bookmark", rkey, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Put a Bookmark record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="record"></param>
        /// <param name="validate"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<PutRecordOutput?>> PutBookmarkAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, FishyFlip.Lexicon.Community.Lexicon.Bookmarks.Bookmark record, bool? validate = default, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.PutRecordAsync(repo, "community.lexicon.bookmarks.bookmark", rkey, record, validate, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// List Bookmark records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListBookmarkAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(repo, "community.lexicon.bookmarks.bookmark", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// List Bookmark records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListBookmarkAsync(this FishyFlip.ATProtocol atp, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "community.lexicon.bookmarks.bookmark", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// Get Bookmark records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetBookmarkAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(repo, "community.lexicon.bookmarks.bookmark", rkey, cid, cancellationToken);
        }

        /// <summary>
        /// Get Bookmark records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetBookmarkAsync(this FishyFlip.ATProtocol atp, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "community.lexicon.bookmarks.bookmark", rkey, cid, cancellationToken);
        }
    }
}

