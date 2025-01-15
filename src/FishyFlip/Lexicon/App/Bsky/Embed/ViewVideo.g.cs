// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Embed
{
    public partial class ViewVideo : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVideo"/> class.
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="playlist"></param>
        /// <param name="thumbnail"></param>
        /// <param name="alt"></param>
        /// <param name="aspectRatio">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.AspectRatio"/> (app.bsky.embed.defs#aspectRatio)
        /// </param>
        public ViewVideo(string cid = default, string playlist = default, string? thumbnail = default, string? alt = default, FishyFlip.Lexicon.App.Bsky.Embed.AspectRatio? aspectRatio = default)
        {
            this.Cid = cid;
            this.Playlist = playlist;
            this.Thumbnail = thumbnail;
            this.Alt = alt;
            this.AspectRatio = aspectRatio;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVideo"/> class.
        /// </summary>
        public ViewVideo()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVideo"/> class.
        /// </summary>
        public ViewVideo(CBORObject obj)
        {
            if (obj["cid"] is not null) this.Cid = obj["cid"].AsString();
            if (obj["playlist"] is not null) this.Playlist = obj["playlist"].AsString();
            if (obj["thumbnail"] is not null) this.Thumbnail = obj["thumbnail"].AsString();
            if (obj["alt"] is not null) this.Alt = obj["alt"].AsString();
            if (obj["aspectRatio"] is not null) this.AspectRatio = new FishyFlip.Lexicon.App.Bsky.Embed.AspectRatio(obj["aspectRatio"]);
        }

        /// <summary>
        /// Gets or sets the cid.
        /// </summary>
        [JsonPropertyName("cid")]
        [JsonRequired]
        public string Cid { get; set; }

        /// <summary>
        /// Gets or sets the playlist.
        /// </summary>
        [JsonPropertyName("playlist")]
        [JsonRequired]
        public string Playlist { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public string? Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets the alt.
        /// </summary>
        [JsonPropertyName("alt")]
        public string? Alt { get; set; }

        /// <summary>
        /// Gets or sets the aspectRatio.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Embed.AspectRatio"/> (app.bsky.embed.defs#aspectRatio)
        /// </summary>
        [JsonPropertyName("aspectRatio")]
        public FishyFlip.Lexicon.App.Bsky.Embed.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.embed.video#view";

        public const string RecordType = "app.bsky.embed.video#view";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Embed.ViewVideo>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Embed.ViewVideo>)SourceGenerationContext.Default.AppBskyEmbedViewVideo)!;
        }

        public static ViewVideo FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Embed.ViewVideo>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Embed.ViewVideo>)SourceGenerationContext.Default.AppBskyEmbedViewVideo)!;
        }
    }
}

