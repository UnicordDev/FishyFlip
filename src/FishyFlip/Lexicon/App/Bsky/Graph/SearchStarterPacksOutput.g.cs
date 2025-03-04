// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Graph
{
    public partial class SearchStarterPacksOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStarterPacksOutput"/> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="starterPacks"></param>
        public SearchStarterPacksOutput(string? cursor = default, List<FishyFlip.Lexicon.App.Bsky.Graph.StarterPackViewBasic> starterPacks = default)
        {
            this.Cursor = cursor;
            this.StarterPacks = starterPacks;
            this.Type = "app.bsky.graph.searchStarterPacks#SearchStarterPacksOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStarterPacksOutput"/> class.
        /// </summary>
        public SearchStarterPacksOutput()
        {
            this.Type = "app.bsky.graph.searchStarterPacks#SearchStarterPacksOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStarterPacksOutput"/> class.
        /// </summary>
        public SearchStarterPacksOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["starterPacks"] is not null) this.StarterPacks = obj["starterPacks"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Graph.StarterPackViewBasic(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets the starterPacks.
        /// </summary>
        [JsonPropertyName("starterPacks")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.App.Bsky.Graph.StarterPackViewBasic> StarterPacks { get; set; }

        public const string RecordType = "app.bsky.graph.searchStarterPacks#SearchStarterPacksOutput";

        public static SearchStarterPacksOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Graph.SearchStarterPacksOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Graph.SearchStarterPacksOutput>)SourceGenerationContext.Default.AppBskyGraphSearchStarterPacksOutput)!;
        }
    }
}

