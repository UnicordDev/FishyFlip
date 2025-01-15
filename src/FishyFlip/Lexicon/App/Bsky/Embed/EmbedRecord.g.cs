// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Embed
{
    public partial class EmbedRecord : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRecord"/> class.
        /// </summary>
        /// <param name="record">
        /// <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.StrongRef"/> (com.atproto.repo.strongRef)
        /// </param>
        public EmbedRecord(Com.Atproto.Repo.StrongRef record = default)
        {
            this.Record = record;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRecord"/> class.
        /// </summary>
        public EmbedRecord()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRecord"/> class.
        /// </summary>
        public EmbedRecord(CBORObject obj)
        {
            if (obj["record"] is not null) this.Record = new FishyFlip.Lexicon.Com.Atproto.Repo.StrongRef(obj["record"]);
        }

        /// <summary>
        /// Gets or sets the record.
        /// <br/> <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.StrongRef"/> (com.atproto.repo.strongRef)
        /// </summary>
        [JsonPropertyName("record")]
        [JsonRequired]
        public Com.Atproto.Repo.StrongRef Record { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.embed.record";

        public const string RecordType = "app.bsky.embed.record";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Embed.EmbedRecord>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Embed.EmbedRecord>)SourceGenerationContext.Default.AppBskyEmbedEmbedRecord)!;
        }

        public static EmbedRecord FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Embed.EmbedRecord>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Embed.EmbedRecord>)SourceGenerationContext.Default.AppBskyEmbedEmbedRecord)!;
        }
    }
}

