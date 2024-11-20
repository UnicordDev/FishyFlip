// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Notification
{

    /// <summary>
    /// app.bsky.notification Endpoint Class.
    /// </summary>
    public sealed class BlueskyNotification
    {

        private ATProtocol atp;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueskyNotification"/> class.
        /// </summary>
        /// <param name="atp"><see cref="ATProtocol"/>.</param>
        internal BlueskyNotification(ATProtocol atp)
        {
            this.atp = atp;
        }

        /// <summary>
        /// Gets the ATProtocol.
        /// </summary>
        internal ATProtocol ATProtocol => this.atp;


        /// <summary>
        /// Count the number of unread notifications for the requesting account. Requires auth.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Notification.GetUnreadCountOutput?>> GetUnreadCountAsync (bool? priority = default, DateTime? seenAt = default, CancellationToken cancellationToken = default)
        {
            return atp.GetUnreadCountAsync(priority, seenAt, cancellationToken);
        }


        /// <summary>
        /// Enumerate notifications for the requesting account. Requires auth.
        /// </summary>
        public Task<Result<FishyFlip.Lexicon.App.Bsky.Notification.ListNotificationsOutput?>> ListNotificationsAsync (int? limit = 50, bool? priority = default, string? cursor = default, DateTime? seenAt = default, CancellationToken cancellationToken = default)
        {
            return atp.ListNotificationsAsync(limit, priority, cursor, seenAt, cancellationToken);
        }


        /// <summary>
        /// Set notification-related preferences for an account. Requires auth.
        /// </summary>
        public Task<Result<Success?>> PutPreferencesAsync (bool priority, CancellationToken cancellationToken = default)
        {
            return atp.PutPreferencesAsync(priority, cancellationToken);
        }


        /// <summary>
        /// Register to receive push notifications, via a specified service, for the requesting account. Requires auth.
        /// </summary>
        public Task<Result<Success?>> RegisterPushAsync (FishyFlip.Models.ATDid serviceDid, string token, string platform, string appId, CancellationToken cancellationToken = default)
        {
            return atp.RegisterPushAsync(serviceDid, token, platform, appId, cancellationToken);
        }


        /// <summary>
        /// Notify server that the requesting account has seen notifications. Requires auth.
        /// </summary>
        public Task<Result<Success?>> UpdateSeenAsync (DateTime seenAt, CancellationToken cancellationToken = default)
        {
            return atp.UpdateSeenAsync(seenAt, cancellationToken);
        }

    }
}

