// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Embed
{
    public partial class ViewRecordWithMedia : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewRecordWithMedia"/> class.
        /// </summary>
        /// <param name="record">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef"/> (app.bsky.embed.record#view)
        /// </param>
        /// <param name="media">
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewImages"/> (app.bsky.embed.images#view) <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewVideo"/> (app.bsky.embed.video#view) <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewExternal"/> (app.bsky.embed.external#view) <br/>
        /// </param>
        public ViewRecordWithMedia(FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef record = default, ATObject media = default)
        {
            this.Record = record;
            this.Media = media;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewRecordWithMedia"/> class.
        /// </summary>
        public ViewRecordWithMedia()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewRecordWithMedia"/> class.
        /// </summary>
        public ViewRecordWithMedia(CBORObject obj)
        {
            if (obj["record"] is not null) this.Record = new FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef(obj["record"]);
            if (obj["media"] is not null) this.Media = obj["media"].ToATObject();
        }

        /// <summary>
        /// Gets or sets the record.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef"/> (app.bsky.embed.record#view)
        /// </summary>
        [JsonPropertyName("record")]
        [JsonRequired]
        public FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef Record { get; set; }

        /// <summary>
        /// Gets or sets the media.
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewImages"/> (app.bsky.embed.images#view) <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewVideo"/> (app.bsky.embed.video#view) <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewExternal"/> (app.bsky.embed.external#view) <br/>
        /// </summary>
        [JsonPropertyName("media")]
        [JsonRequired]
        public ATObject Media { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.embed.recordWithMedia#view";

        public const string RecordType = "app.bsky.embed.recordWithMedia#view";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordWithMedia>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordWithMedia>)SourceGenerationContext.Default.AppBskyEmbedViewRecordWithMedia)!;
        }

        public static ViewRecordWithMedia FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordWithMedia>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordWithMedia>)SourceGenerationContext.Default.AppBskyEmbedViewRecordWithMedia)!;
        }
    }
}

