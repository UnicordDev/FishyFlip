// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Notification
{
    public partial class PutPreferencesInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PutPreferencesInput"/> class.
        /// </summary>
        /// <param name="priority"></param>
        public PutPreferencesInput(bool? priority = default)
        {
            this.Priority = priority;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PutPreferencesInput"/> class.
        /// </summary>
        public PutPreferencesInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="PutPreferencesInput"/> class.
        /// </summary>
        public PutPreferencesInput(CBORObject obj)
        {
            if (obj["priority"] is not null) this.Priority = obj["priority"].AsBoolean();
        }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        [JsonPropertyName("priority")]
        [JsonRequired]
        public bool? Priority { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.notification.putPreferences#PutPreferencesInput";

        public const string RecordType = "app.bsky.notification.putPreferences#PutPreferencesInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Notification.PutPreferencesInput>(this, (JsonTypeInfo<App.Bsky.Notification.PutPreferencesInput>)SourceGenerationContext.Default.AppBskyNotificationPutPreferencesInput)!;
        }

        public static PutPreferencesInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Notification.PutPreferencesInput>(json, (JsonTypeInfo<App.Bsky.Notification.PutPreferencesInput>)SourceGenerationContext.Default.AppBskyNotificationPutPreferencesInput)!;
        }
    }
}

