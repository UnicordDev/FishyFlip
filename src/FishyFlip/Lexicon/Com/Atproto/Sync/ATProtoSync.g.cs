// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Sync
{

    /// <summary>
    /// com.atproto.sync Endpoint Class.
    /// </summary>
    public sealed class ATProtoSync
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ATProtoSync"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ATProtoSync(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Get a blob associated with a given account. Returns the full blob as originally uploaded. Does not require auth; implemented by PDS.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.BlobNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoTakendownError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoSuspendedError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoDeactivatedError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="cid"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<byte[]?>> GetBlobAsync (FishyFlip.Models.ATDid did, string cid, CancellationToken cancellationToken = default)
        {
            return atp.GetBlobAsync(did, cid, cancellationToken);
        }


        /// <summary>
        /// Get data blocks from a given repo, by CID. For example, intermediate MST nodes, or records. Does not require auth; implemented by PDS.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.BlockNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoTakendownError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoSuspendedError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoDeactivatedError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="cids"></param>
        /// <param name="onDecoded"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> GetBlocksAsync (FishyFlip.Models.ATDid did, List<string> cids, OnCarDecoded onDecoded, CancellationToken cancellationToken = default)
        {
            return atp.GetBlocksAsync(did, cids, onDecoded, cancellationToken);
        }


        /// <summary>
        /// Get the current commit CID & revision of the specified repo. Does not require auth.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.RepoNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoTakendownError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoSuspendedError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoDeactivatedError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Sync.GetLatestCommitOutput?>> GetLatestCommitAsync (FishyFlip.Models.ATDid did, CancellationToken cancellationToken = default)
        {
            return atp.GetLatestCommitAsync(did, cancellationToken);
        }


        /// <summary>
        /// Get data blocks needed to prove the existence or non-existence of record in the current version of repo. Does not require auth.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.RecordNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoTakendownError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoSuspendedError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoDeactivatedError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="collection"></param>
        /// <param name="rkey"></param>
        /// <param name="onDecoded"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> GetRecordAsync (FishyFlip.Models.ATDid did, string collection, string rkey, OnCarDecoded onDecoded, CancellationToken cancellationToken = default)
        {
            return atp.GetRecordAsync(did, collection, rkey, onDecoded, cancellationToken);
        }


        /// <summary>
        /// Download a repository export as CAR file. Optionally only a 'diff' since a previous revision. Does not require auth; implemented by PDS.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.RepoNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoTakendownError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoSuspendedError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoDeactivatedError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="onDecoded"></param>
        /// <param name="since"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> GetRepoAsync (FishyFlip.Models.ATDid did, OnCarDecoded onDecoded, string? since = default, CancellationToken cancellationToken = default)
        {
            return atp.GetRepoAsync(did, onDecoded, since, cancellationToken);
        }


        /// <summary>
        /// Get the hosting status for a repository, on this server. Expected to be implemented by PDS and Relay.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.RepoNotFoundError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Sync.GetRepoStatusOutput?>> GetRepoStatusAsync (FishyFlip.Models.ATDid did, CancellationToken cancellationToken = default)
        {
            return atp.GetRepoStatusAsync(did, cancellationToken);
        }


        /// <summary>
        /// List blob CIDs for an account, since some repo revision. Does not require auth; implemented by PDS.
        /// <br/> Possible Errors: <br/>
        /// <see cref="FishyFlip.Lexicon.RepoNotFoundError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoTakendownError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoSuspendedError"/>  <br/>
        /// <see cref="FishyFlip.Lexicon.RepoDeactivatedError"/>  <br/>
        /// </summary>
        /// <param name="did"></param>
        /// <param name="since"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Sync.ListBlobsOutput?>> ListBlobsAsync (FishyFlip.Models.ATDid did, string? since = default, int? limit = 500, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.ListBlobsAsync(did, since, limit, cursor, cancellationToken);
        }


        /// <summary>
        /// Enumerates all the DID, rev, and commit CID for all repos hosted by this service. Does not require auth; implemented by PDS and Relay.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Sync.ListReposOutput?>> ListReposAsync (int? limit = 500, string? cursor = default, CancellationToken cancellationToken = default)
        {
            return atp.ListReposAsync(limit, cursor, cancellationToken);
        }


        /// <summary>
        /// Notify a crawling service of a recent update, and that crawling should resume. Intended use is after a gap between repo stream events caused the crawling service to disconnect. Does not require auth; implemented by Relay.
        /// </summary>
        /// <param name="hostname"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> NotifyOfUpdateAsync (string hostname, CancellationToken cancellationToken = default)
        {
            return atp.NotifyOfUpdateAsync(hostname, cancellationToken);
        }


        /// <summary>
        /// Request a service to persistently crawl hosted repos. Expected use is new PDS instances declaring their existence to Relays. Does not require auth.
        /// </summary>
        /// <param name="hostname"></param>
        /// <param name="cancellationToken"></param>
        public Task<Result<Success?>> RequestCrawlAsync (string hostname, CancellationToken cancellationToken = default)
        {
            return atp.RequestCrawlAsync(hostname, cancellationToken);
        }

    }
}

