// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Server
{

    /// <summary>
    /// tools.ozone.server Endpoint Group.
    /// </summary>
    public static class ServerEndpoints
    {

       public const string GetConfig = "/xrpc/tools.ozone.server.getConfig";


        /// <summary>
        /// Get details about ozone's server configuration.
        /// </summary>
        /// <param name="atp"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Result of <see cref="FishyFlip.Lexicon.Tools.Ozone.Server.GetConfigOutput?"/></returns>
        public static Task<Result<FishyFlip.Lexicon.Tools.Ozone.Server.GetConfigOutput?>> GetConfigAsync (this FishyFlip.ATProtocol atp, CancellationToken cancellationToken = default)
        {
            var endpointUrl = GetConfig.ToString();
            return atp.Client.Get<FishyFlip.Lexicon.Tools.Ozone.Server.GetConfigOutput>(endpointUrl, atp.Options.SourceGenerationContext.ToolsOzoneServerGetConfigOutput!, atp.Options.JsonSerializerOptions, cancellationToken, atp.Options.Logger);
        }

    }
}

