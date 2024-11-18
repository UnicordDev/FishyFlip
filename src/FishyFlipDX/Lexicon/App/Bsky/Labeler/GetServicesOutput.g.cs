// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Labeler
{
    public partial class GetServicesOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServicesOutput"/> class.
        /// </summary>
        public GetServicesOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetServicesOutput"/> class.
        /// </summary>
        public GetServicesOutput(CBORObject obj)
        {
            if (obj["views"] is not null) this.Views = obj["views"].Values.Select(n => n is not null ? n.ToATObject() : null).ToList();
        }

        [JsonPropertyName("views")]
        [JsonRequired]
        public List<ATObject?>? Views { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.labeler.getServices#GetServicesOutput";

        public const string RecordType = "app.bsky.labeler.getServices#GetServicesOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<App.Bsky.Labeler.GetServicesOutput>(this, (JsonTypeInfo<App.Bsky.Labeler.GetServicesOutput>)SourceGenerationContext.Default.AppBskyLabelerGetServicesOutput)!;
        }

        public static GetServicesOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<App.Bsky.Labeler.GetServicesOutput>(json, (JsonTypeInfo<App.Bsky.Labeler.GetServicesOutput>)SourceGenerationContext.Default.AppBskyLabelerGetServicesOutput)!;
        }
    }
}

