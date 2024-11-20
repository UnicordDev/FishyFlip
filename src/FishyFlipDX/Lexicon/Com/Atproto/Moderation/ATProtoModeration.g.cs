// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Moderation
{

    /// <summary>
    /// com.atproto.moderation Endpoint Class.
    /// </summary>
    public sealed class ATProtoModeration
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="ATProtoModeration"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal ATProtoModeration(ATProtocol atp)
        {
            this.atp = atp;
        }


        /// <summary>
        /// Submit a moderation report regarding an atproto account or record. Implemented by moderation services (with PDS proxying), and requires auth.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.Com.Atproto.Moderation.CreateReportOutput?>> CreateReportAsync (string reasonType, ATObject subject, string? reason = default, CancellationToken cancellationToken = default)
        {
            return atp.CreateReportAsync(reasonType, subject, reason, cancellationToken);
        }

    }
}

