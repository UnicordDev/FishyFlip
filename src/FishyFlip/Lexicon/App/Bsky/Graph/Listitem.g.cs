// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Graph
{
    /// <summary>
    /// Record representing an account's inclusion on a specific list. The AppView will ignore duplicate listitem records.
    /// </summary>
    public partial class Listitem : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Listitem"/> class.
        /// </summary>
        /// <param name="subject">The account which is included on the list.</param>
        /// <param name="list">Reference (AT-URI) to the list record (app.bsky.graph.list).</param>
        /// <param name="createdAt"></param>
        public Listitem(FishyFlip.Models.ATDid? subject, FishyFlip.Models.ATUri? list, DateTime? createdAt = default)
        {
            this.Subject = subject;
            this.List = list;
            this.CreatedAt = createdAt ?? DateTime.UtcNow;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Listitem"/> class.
        /// </summary>
        public Listitem()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Listitem"/> class.
        /// </summary>
        public Listitem(CBORObject obj)
        {
            if (obj["subject"] is not null) this.Subject = obj["subject"].ToATDid();
            if (obj["list"] is not null) this.List = obj["list"].ToATUri();
            if (obj["createdAt"] is not null) this.CreatedAt = obj["createdAt"].ToDateTime();
        }

        /// <summary>
        /// Gets or sets the subject.
        /// <br/> The account which is included on the list.
        /// </summary>
        [JsonPropertyName("subject")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Subject { get; set; }

        /// <summary>
        /// Gets or sets the list.
        /// <br/> Reference (AT-URI) to the list record (app.bsky.graph.list).
        /// </summary>
        [JsonPropertyName("list")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri? List { get; set; }

        /// <summary>
        /// Gets or sets the createdAt.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.graph.listitem";

        public const string RecordType = "app.bsky.graph.listitem";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Graph.Listitem>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Graph.Listitem>)SourceGenerationContext.Default.AppBskyGraphListitem)!;
        }

        public static Listitem FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Graph.Listitem>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Graph.Listitem>)SourceGenerationContext.Default.AppBskyGraphListitem)!;
        }
    }
}

