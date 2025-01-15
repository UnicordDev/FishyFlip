// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Notification
{
    public partial class UpdateSeenInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSeenInput"/> class.
        /// </summary>
        /// <param name="seenAt"></param>
        public UpdateSeenInput(DateTime? seenAt = default)
        {
            this.SeenAt = seenAt;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSeenInput"/> class.
        /// </summary>
        public UpdateSeenInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSeenInput"/> class.
        /// </summary>
        public UpdateSeenInput(CBORObject obj)
        {
            if (obj["seenAt"] is not null) this.SeenAt = obj["seenAt"].ToDateTime();
        }

        /// <summary>
        /// Gets or sets the seenAt.
        /// </summary>
        [JsonPropertyName("seenAt")]
        [JsonRequired]
        public DateTime? SeenAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.notification.updateSeen#UpdateSeenInput";

        public const string RecordType = "app.bsky.notification.updateSeen#UpdateSeenInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Notification.UpdateSeenInput>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Notification.UpdateSeenInput>)SourceGenerationContext.Default.AppBskyNotificationUpdateSeenInput)!;
        }

        public static UpdateSeenInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Notification.UpdateSeenInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Notification.UpdateSeenInput>)SourceGenerationContext.Default.AppBskyNotificationUpdateSeenInput)!;
        }
    }
}

