// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Server
{

    /// <summary>
    /// tools.ozone.server Endpoint Class.
    /// </summary>
    public sealed class ToolsOzoneServer
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsOzoneServer"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ToolsOzoneServer(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Get details about ozone's server configuration.
        /// </summary>
        /// <param name="cancellationToken"></param>
        public Task<Result<FishyFlip.Lexicon.Tools.Ozone.Server.GetConfigOutput?>> GetConfigAsync (CancellationToken cancellationToken = default)
        {
            return atp.GetConfigAsync(cancellationToken);
        }

    }
}

