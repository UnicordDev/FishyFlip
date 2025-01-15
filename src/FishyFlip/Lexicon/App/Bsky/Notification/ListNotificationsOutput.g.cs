// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Notification
{
    public partial class ListNotificationsOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNotificationsOutput"/> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="notifications"></param>
        /// <param name="priority"></param>
        /// <param name="seenAt"></param>
        public ListNotificationsOutput(string? cursor = default, List<FishyFlip.Lexicon.App.Bsky.Notification.Notification> notifications = default, bool? priority = default, DateTime? seenAt = default)
        {
            this.Cursor = cursor;
            this.Notifications = notifications;
            this.Priority = priority;
            this.SeenAt = seenAt;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListNotificationsOutput"/> class.
        /// </summary>
        public ListNotificationsOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListNotificationsOutput"/> class.
        /// </summary>
        public ListNotificationsOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["notifications"] is not null) this.Notifications = obj["notifications"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Notification.Notification(n)).ToList();
            if (obj["priority"] is not null) this.Priority = obj["priority"].AsBoolean();
            if (obj["seenAt"] is not null) this.SeenAt = obj["seenAt"].ToDateTime();
        }

        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets the notifications.
        /// </summary>
        [JsonPropertyName("notifications")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.App.Bsky.Notification.Notification> Notifications { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        [JsonPropertyName("priority")]
        public bool? Priority { get; set; }

        /// <summary>
        /// Gets or sets the seenAt.
        /// </summary>
        [JsonPropertyName("seenAt")]
        public DateTime? SeenAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.notification.listNotifications#ListNotificationsOutput";

        public const string RecordType = "app.bsky.notification.listNotifications#ListNotificationsOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Notification.ListNotificationsOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Notification.ListNotificationsOutput>)SourceGenerationContext.Default.AppBskyNotificationListNotificationsOutput)!;
        }

        public static ListNotificationsOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Notification.ListNotificationsOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Notification.ListNotificationsOutput>)SourceGenerationContext.Default.AppBskyNotificationListNotificationsOutput)!;
        }
    }
}

