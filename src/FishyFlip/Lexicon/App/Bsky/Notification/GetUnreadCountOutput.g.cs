// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Notification
{
    public partial class GetUnreadCountOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnreadCountOutput"/> class.
        /// </summary>
        /// <param name="count"></param>
        public GetUnreadCountOutput(long count = default)
        {
            this.Count = count;
            this.Type = "app.bsky.notification.getUnreadCount#GetUnreadCountOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnreadCountOutput"/> class.
        /// </summary>
        public GetUnreadCountOutput()
        {
            this.Type = "app.bsky.notification.getUnreadCount#GetUnreadCountOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnreadCountOutput"/> class.
        /// </summary>
        public GetUnreadCountOutput(CBORObject obj)
        {
            if (obj["count"] is not null) this.Count = obj["count"].AsInt64Value();
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        [JsonPropertyName("count")]
        [JsonRequired]
        public long Count { get; set; }

        public const string RecordType = "app.bsky.notification.getUnreadCount#GetUnreadCountOutput";

        public static GetUnreadCountOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Notification.GetUnreadCountOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Notification.GetUnreadCountOutput>)SourceGenerationContext.Default.AppBskyNotificationGetUnreadCountOutput)!;
        }
    }
}

