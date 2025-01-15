// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Ma.Tokono.Byov
{
    /// <summary>
    /// A channel subscription.
    /// </summary>
    public partial class Subscription : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="createdAt"></param>
        public Subscription(string? subject, DateTime? createdAt = default)
        {
            this.CreatedAt = createdAt ?? DateTime.UtcNow;
            this.Subject = subject;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        public Subscription()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        public Subscription(CBORObject obj)
        {
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
            if (obj["subject"] is not null) this.Subject = obj["subject"].AsString();
        }

        /// <summary>
        /// Gets or sets the createdAt.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; } = default;

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "ma.tokono.byov.subscription";

        public const string RecordType = "ma.tokono.byov.subscription";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Ma.Tokono.Byov.Subscription>(this, (JsonTypeInfo<FishyFlip.Lexicon.Ma.Tokono.Byov.Subscription>)SourceGenerationContext.Default.MaTokonoByovSubscription)!;
        }

        public static Subscription FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Ma.Tokono.Byov.Subscription>(json, (JsonTypeInfo<FishyFlip.Lexicon.Ma.Tokono.Byov.Subscription>)SourceGenerationContext.Default.MaTokonoByovSubscription)!;
        }
    }
}

