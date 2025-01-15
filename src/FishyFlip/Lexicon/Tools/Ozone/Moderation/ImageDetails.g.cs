// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    public partial class ImageDetails : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetails"/> class.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public ImageDetails(long width = default, long height = default)
        {
            this.Width = width;
            this.Height = height;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetails"/> class.
        /// </summary>
        public ImageDetails()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDetails"/> class.
        /// </summary>
        public ImageDetails(CBORObject obj)
        {
            if (obj["width"] is not null) this.Width = obj["width"].AsInt64Value();
            if (obj["height"] is not null) this.Height = obj["height"].AsInt64Value();
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonPropertyName("width")]
        [JsonRequired]
        public long Width { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonPropertyName("height")]
        [JsonRequired]
        public long Height { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.defs#imageDetails";

        public const string RecordType = "tools.ozone.moderation.defs#imageDetails";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Tools.Ozone.Moderation.ImageDetails>(this, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Moderation.ImageDetails>)SourceGenerationContext.Default.ToolsOzoneModerationImageDetails)!;
        }

        public static ImageDetails FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Tools.Ozone.Moderation.ImageDetails>(json, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Moderation.ImageDetails>)SourceGenerationContext.Default.ToolsOzoneModerationImageDetails)!;
        }
    }
}

