// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

using FishyFlip.Lexicon.Com.Atproto.Repo;

namespace FishyFlip.Lexicon
{

    /// <summary>
    /// Extension methods for app.bsky.labeler.
    /// </summary>
    public static class BlueskyLabelerExtensions
    {

        /// <summary>
        /// Create a Service record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="record"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, FishyFlip.Lexicon.App.Bsky.Labeler.Service record, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.CreateRecordAsync(atp.ATProtocol.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Create a Service record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="policies">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Labeler.LabelerPolicies"/> (app.bsky.labeler.defs#labelerPolicies)
        /// </param>
        /// <param name="labels">
        /// <br/> Union Types: <br/>
        /// com.atproto.label.defs#selfLabels <br/>
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="rkey"></param>
        /// <param name="validate"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<CreateRecordOutput?>> CreateServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, FishyFlip.Lexicon.App.Bsky.Labeler.LabelerPolicies? policies, FishyFlip.Lexicon.Com.Atproto.Label.SelfLabels? labels = default, DateTime? createdAt = default, string? rkey = default, bool? validate = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            var record = new FishyFlip.Lexicon.App.Bsky.Labeler.Service();
            record.Policies = policies;
            record.Labels = labels;
            record.CreatedAt = createdAt ?? DateTime.UtcNow;
            return atp.ATProtocol.CreateRecordAsync(atp.ATProtocol.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", record, rkey, validate, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Delete a Service record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="rkey"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<DeleteRecordOutput?>> DeleteServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, string rkey, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.DeleteRecordAsync(atp.ATProtocol.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", rkey, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// Put a Service record.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="rkey"></param>
        /// <param name="record"></param>
        /// <param name="validate"></param>
        /// <param name="swapRecord"></param>
        /// <param name="swapCommit"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<PutRecordOutput?>> PutServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, string rkey, FishyFlip.Lexicon.App.Bsky.Labeler.Service record, bool? validate = default, string? swapRecord = default, string? swapCommit = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.PutRecordAsync(atp.ATProtocol.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", rkey, record, validate, swapRecord, swapCommit, cancellationToken);
        }

        /// <summary>
        /// List Service records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.ListRecordsAsync(atp.ATProtocol.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// List Service records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="reverse"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<ListRecordsOutput?>> ListServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, FishyFlip.Models.ATIdentifier repo, int? limit = 50, string? cursor = default, bool? reverse = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.ListRecordsAsync(repo, "app.bsky.labeler.service", limit, cursor, reverse, cancellationToken);
        }

        /// <summary>
        /// Get Service records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.GetRecordAsync(atp.ATProtocol.SessionManager.Session?.Did ?? throw new InvalidOperationException("Session did is required."), "app.bsky.labeler.service", rkey, cid, cancellationToken);
        }

        /// <summary>
        /// Get Service records.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="repo"></param>
        /// <param name="rkey"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public static Task<Result<GetRecordOutput?>> GetServiceAsync(this FishyFlip.Lexicon.App.Bsky.Labeler.BlueskyLabeler atp, FishyFlip.Models.ATIdentifier repo, string rkey, string? cid = default, CancellationToken cancellationToken = default)
        {
            return atp.ATProtocol.GetRecordAsync(repo, "app.bsky.labeler.service", rkey, cid, cancellationToken);
        }
    }
}

