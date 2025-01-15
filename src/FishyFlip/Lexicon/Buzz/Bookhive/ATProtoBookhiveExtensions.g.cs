// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

using FishyFlip.Lexicon.Com.Atproto.Repo;

namespace FishyFlip.Lexicon.Buzz.Bookhive
{

    /// <summary>
    /// Extension methods for buzz.bookhive.
    /// </summary>
    public static class ATProtoBookhiveExtensions
    {

        /// <summary>
        /// Create a Book record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Lexicon.Buzz.Bookhive.Book record, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.book", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Create a Book record.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="collection"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateBookAsync(this FishyFlip.ATProtocol atp, string? title, string? authors, string? hiveId, DateTime? createdAt = default, DateTime? startedAt = default, DateTime? finishedAt = default, Blob? cover = default, string? status = default, long? stars = default, string? review = default, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            var record = new FishyFlip.Lexicon.Buzz.Bookhive.Book();
            record.Title = title;
            record.Authors = authors;
            record.HiveId = hiveId;
            record.CreatedAt = createdAt ?? DateTime.UtcNow;
            record.StartedAt = startedAt;
            record.FinishedAt = finishedAt;
            record.Cover = cover;
            record.Status = status;
            record.Stars = stars;
            record.Review = review;
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.book", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Delete a Book record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<DeleteRecordOutput?>> DeleteBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.DeleteRecordAsync(repo, "buzz.bookhive.book", rkey, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Put a Book record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="record"></param>
        /// <param name="validate"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<PutRecordOutput?>> PutBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, FishyFlip.Lexicon.Buzz.Bookhive.Book record, bool? validate = default, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.PutRecordAsync(repo, "buzz.bookhive.book", rkey, record, validate, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// List Book records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(repo, "buzz.bookhive.book", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// List Book records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListBookAsync(this FishyFlip.ATProtocol atp, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.book", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// Get Book records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(repo, "buzz.bookhive.book", rkey, cid, cancellationToken);
        }

        /// <summary>
        /// Get Book records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetBookAsync(this FishyFlip.ATProtocol atp, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.book", rkey, cid, cancellationToken);
        }
        /// <summary>
        /// Create a Buzz record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateBuzzAsync(this FishyFlip.ATProtocol atp, FishyFlip.Lexicon.Buzz.Bookhive.Buzz record, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.buzz", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Create a Buzz record.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="collection"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateBuzzAsync(this FishyFlip.ATProtocol atp, string? comment, Com.Atproto.Repo.StrongRef? parent, Com.Atproto.Repo.StrongRef? book, DateTime? createdAt = default, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            var record = new FishyFlip.Lexicon.Buzz.Bookhive.Buzz();
            record.Comment = comment;
            record.CreatedAt = createdAt ?? DateTime.UtcNow;
            record.Parent = parent;
            record.Book = book;
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.buzz", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Delete a Buzz record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<DeleteRecordOutput?>> DeleteBuzzAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.DeleteRecordAsync(repo, "buzz.bookhive.buzz", rkey, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Put a Buzz record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="record"></param>
        /// <param name="validate"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<PutRecordOutput?>> PutBuzzAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, FishyFlip.Lexicon.Buzz.Bookhive.Buzz record, bool? validate = default, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.PutRecordAsync(repo, "buzz.bookhive.buzz", rkey, record, validate, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// List Buzz records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListBuzzAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(repo, "buzz.bookhive.buzz", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// List Buzz records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListBuzzAsync(this FishyFlip.ATProtocol atp, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.buzz", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// Get Buzz records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetBuzzAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(repo, "buzz.bookhive.buzz", rkey, cid, cancellationToken);
        }

        /// <summary>
        /// Get Buzz records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetBuzzAsync(this FishyFlip.ATProtocol atp, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.buzz", rkey, cid, cancellationToken);
        }
        /// <summary>
        /// Create a HiveBook record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateHiveBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Lexicon.Buzz.Bookhive.HiveBook record, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.hiveBook", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Create a HiveBook record.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="collection"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateHiveBookAsync(this FishyFlip.ATProtocol atp, string? title, string? authors, string? id, string? thumbnail, DateTime? updatedAt, string? source = default, string? sourceUrl = default, string? sourceId = default, string? cover = default, string? description = default, long? rating = default, long? ratingsCount = default, DateTime? createdAt = default, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            var record = new FishyFlip.Lexicon.Buzz.Bookhive.HiveBook();
            record.Title = title;
            record.Authors = authors;
            record.Id = id;
            record.Source = source;
            record.SourceUrl = sourceUrl;
            record.SourceId = sourceId;
            record.Cover = cover;
            record.Thumbnail = thumbnail;
            record.Description = description;
            record.Rating = rating;
            record.RatingsCount = ratingsCount;
            record.CreatedAt = createdAt ?? DateTime.UtcNow;
            record.UpdatedAt = updatedAt;
            return atp.CreateRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.hiveBook", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Delete a HiveBook record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<DeleteRecordOutput?>> DeleteHiveBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.DeleteRecordAsync(repo, "buzz.bookhive.hiveBook", rkey, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Put a HiveBook record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="record"></param>
        /// <param name="validate"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<PutRecordOutput?>> PutHiveBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, FishyFlip.Lexicon.Buzz.Bookhive.HiveBook record, bool? validate = default, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.PutRecordAsync(repo, "buzz.bookhive.hiveBook", rkey, record, validate, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// List HiveBook records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListHiveBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(repo, "buzz.bookhive.hiveBook", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// List HiveBook records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListHiveBookAsync(this FishyFlip.ATProtocol atp, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ListRecordsAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.hiveBook", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// Get HiveBook records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetHiveBookAsync(this FishyFlip.ATProtocol atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(repo, "buzz.bookhive.hiveBook", rkey, cid, cancellationToken);
        }

        /// <summary>
        /// Get HiveBook records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetHiveBookAsync(this FishyFlip.ATProtocol atp, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(atp.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "buzz.bookhive.hiveBook", rkey, cid, cancellationToken);
        }
    }
}

