// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Signature
{

    /// <summary>
    /// tools.ozone.signature Endpoint Class.
    /// </summary>
    public sealed class ToolsOzoneSignature
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneSignature"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ToolsOzoneSignature(ATProtocol atp)
        {
            this.atp = atp;
        }


        /// <summary>
        /// Find all correlated threat signatures between 2 or more accounts.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Signature.FindCorrelationOutput?>> FindCorrelationAsync (List<FishyFlip.Models.ATDid?> dids, CancellationToken cancellationToken = default)
        {
            return atp.FindCorrelationAsync(dids, cancellationToken);
        }


        /// <summary>
        /// Get accounts that share some matching threat signatures with the root account.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Signature.FindRelatedAccountsOutput?>> FindRelatedAccountsAsync (FishyFlip.Models.ATDid did, string? cursor = default, int? limit = 50, CancellationToken cancellationToken = default)
        {
            return atp.FindRelatedAccountsAsync(did, cursor, limit, cancellationToken);
        }


        /// <summary>
        /// Search for accounts that match one or more threat signature values.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Signature.SearchAccountsOutput?>> SearchAccountsAsync (List<string?> values, string? cursor = default, int? limit = 50, CancellationToken cancellationToken = default)
        {
            return atp.SearchAccountsAsync(values, cursor, limit, cancellationToken);
        }

    }
}

