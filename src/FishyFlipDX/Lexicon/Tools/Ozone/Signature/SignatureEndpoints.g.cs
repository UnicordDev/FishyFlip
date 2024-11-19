// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Signature
{

    /// <summary>
    /// tools.ozone.signature Endpoint Group.
    /// </summary>
    public static class SignatureEndpoints
    {

       public const string FindCorrelation = "/xrpc/tools.ozone.signature.findCorrelation";

       public const string FindRelatedAccounts = "/xrpc/tools.ozone.signature.findRelatedAccounts";

       public const string SearchAccounts = "/xrpc/tools.ozone.signature.searchAccounts";


        /// <summary>
        /// Find all correlated threat signatures between 2 or more accounts.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Tools.Ozone.Signature.FindCorrelationOutput?>> FindCorrelationAsync (this FishyFlip.ATProtocol atp, List<FishyFlip.Models.ATDid?> dids, CancellationToken cancellationToken = default)
        {
            var endpointUrl = FindCorrelation.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            if (dids != null)
            {
                queryStrings.Add(string.Join("&", dids.Select(n => "dids=" + n)));
            }

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Tools.Ozone.Signature.FindCorrelationOutput>(endpointUrl, atp.Options.SourceGenerationContext.ToolsOzoneSignatureFindCorrelationOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Get accounts that share some matching threat signatures with the root account.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Tools.Ozone.Signature.FindRelatedAccountsOutput?>> FindRelatedAccountsAsync (this FishyFlip.ATProtocol atp, FishyFlip.Models.ATDid did, string? cursor = default, int? limit = 50, CancellationToken cancellationToken = default)
        {
            var endpointUrl = FindRelatedAccounts.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            queryStrings.Add("did=" + did);

            if (cursor != null)
            {
                queryStrings.Add("cursor=" + cursor);
            }

            if (limit != null)
            {
                queryStrings.Add("limit=" + limit);
            }

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Tools.Ozone.Signature.FindRelatedAccountsOutput>(endpointUrl, atp.Options.SourceGenerationContext.ToolsOzoneSignatureFindRelatedAccountsOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }


        /// <summary>
        /// Search for accounts that match one or more threat signature values.
        /// </summary>
        public static Task<Result<FishyFlip.Lexicon.Tools.Ozone.Signature.SearchAccountsOutput?>> SearchAccountsAsync (this FishyFlip.ATProtocol atp, List<string?> values, string? cursor = default, int? limit = 50, CancellationToken cancellationToken = default)
        {
            var endpointUrl = SearchAccounts.ToString();
            endpointUrl += "?";
            List<string> queryStrings = new();
            if (values != null)
            {
                queryStrings.Add(string.Join("&", values.Select(n => "values=" + n)));
            }

            if (cursor != null)
            {
                queryStrings.Add("cursor=" + cursor);
            }

            if (limit != null)
            {
                queryStrings.Add("limit=" + limit);
            }

            endpointUrl += string.Join("&", queryStrings);
            return atp.Client.Get<FishyFlip.Lexicon.Tools.Ozone.Signature.SearchAccountsOutput>(endpointUrl, atp.Options.SourceGenerationContext.ToolsOzoneSignatureSearchAccountsOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }

    }
}

