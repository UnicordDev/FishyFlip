// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Graph
{
    public partial class GetStarterPackOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStarterPackOutput"/> class.
        /// </summary>
        /// <param name="starterPack">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Graph.StarterPackView"/> (app.bsky.graph.defs#starterPackView)
        /// </param>
        public GetStarterPackOutput(FishyFlip.Lexicon.App.Bsky.Graph.StarterPackView? starterPack = default)
        {
            this.StarterPack = starterPack;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetStarterPackOutput"/> class.
        /// </summary>
        public GetStarterPackOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetStarterPackOutput"/> class.
        /// </summary>
        public GetStarterPackOutput(CBORObject obj)
        {
            if (obj["starterPack"] is not null) this.StarterPack = new FishyFlip.Lexicon.App.Bsky.Graph.StarterPackView(obj["starterPack"]);
        }

        /// <summary>
        /// Gets or sets the starterPack.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Graph.StarterPackView"/> (app.bsky.graph.defs#starterPackView)
        /// </summary>
        [JsonPropertyName("starterPack")]
        [JsonRequired]
        public FishyFlip.Lexicon.App.Bsky.Graph.StarterPackView? StarterPack { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.graph.getStarterPack#GetStarterPackOutput";

        public const string RecordType = "app.bsky.graph.getStarterPack#GetStarterPackOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Graph.GetStarterPackOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Graph.GetStarterPackOutput>)SourceGenerationContext.Default.AppBskyGraphGetStarterPackOutput)!;
        }

        public static GetStarterPackOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Graph.GetStarterPackOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Graph.GetStarterPackOutput>)SourceGenerationContext.Default.AppBskyGraphGetStarterPackOutput)!;
        }
    }
}

