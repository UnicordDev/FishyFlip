// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    /// <summary>
    /// A new user experiences (NUX) storage object
    /// </summary>
    public partial class Nux : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Nux"/> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="completed"></param>
        /// <param name="data">Arbitrary data for the NUX. The structure is defined by the NUX itself. Limited to 300 characters.</param>
        /// <param name="expiresAt">The date and time at which the NUX will expire and should be considered completed.</param>
        public Nux(string id = default, bool completed = default, string? data = default, DateTime? expiresAt = default)
        {
            this.Id = id;
            this.Completed = completed;
            this.Data = data;
            this.ExpiresAt = expiresAt;
            this.Type = "app.bsky.actor.defs#nux";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Nux"/> class.
        /// </summary>
        public Nux()
        {
            this.Type = "app.bsky.actor.defs#nux";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Nux"/> class.
        /// </summary>
        public Nux(CBORObject obj)
        {
            if (obj["id"] is not null) this.Id = obj["id"].AsString();
            if (obj["completed"] is not null) this.Completed = obj["completed"].AsBoolean();
            if (obj["data"] is not null) this.Data = obj["data"].AsString();
            if (obj["expiresAt"] is not null) this.ExpiresAt = obj["expiresAt"].ToDateTime();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the completed.
        /// </summary>
        [JsonPropertyName("completed")]
        [JsonRequired]
        public bool Completed { get; set; } = false;

        /// <summary>
        /// Gets or sets the data.
        /// <br/> Arbitrary data for the NUX. The structure is defined by the NUX itself. Limited to 300 characters.
        /// </summary>
        [JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Gets or sets the expiresAt.
        /// <br/> The date and time at which the NUX will expire and should be considered completed.
        /// </summary>
        [JsonPropertyName("expiresAt")]
        public DateTime? ExpiresAt { get; set; }

        public const string RecordType = "app.bsky.actor.defs#nux";

        public static Nux FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.Nux>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.Nux>)SourceGenerationContext.Default.AppBskyActorNux)!;
        }
    }
}

