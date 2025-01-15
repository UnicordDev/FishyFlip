// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Whtwnd.Blog
{
    public partial class Ogp : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Ogp"/> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Ogp(string url = default, long? width = default, long? height = default)
        {
            this.Url = url;
            this.Width = width;
            this.Height = height;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Ogp"/> class.
        /// </summary>
        public Ogp()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Ogp"/> class.
        /// </summary>
        public Ogp(CBORObject obj)
        {
            if (obj["url"] is not null) this.Url = obj["url"].AsString();
            if (obj["width"] is not null) this.Width = obj["width"].AsInt64Value();
            if (obj["height"] is not null) this.Height = obj["height"].AsInt64Value();
        }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        [JsonRequired]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonPropertyName("width")]
        public long? Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonPropertyName("height")]
        public long? Height { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.whtwnd.blog.defs#ogp";

        public const string RecordType = "com.whtwnd.blog.defs#ogp";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Com.Whtwnd.Blog.Ogp>(this, (JsonTypeInfo<FishyFlip.Lexicon.Com.Whtwnd.Blog.Ogp>)SourceGenerationContext.Default.ComWhtwndBlogOgp)!;
        }

        public static Ogp FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Whtwnd.Blog.Ogp>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Whtwnd.Blog.Ogp>)SourceGenerationContext.Default.ComWhtwndBlogOgp)!;
        }
    }
}

