// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Graph
{
    public partial class UnmuteActorInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteActorInput"/> class.
        /// </summary>
        /// <param name="actor"></param>
        public UnmuteActorInput(FishyFlip.Models.ATIdentifier actor = default)
        {
            this.Actor = actor;
            this.Type = "app.bsky.graph.unmuteActor#UnmuteActorInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteActorInput"/> class.
        /// </summary>
        public UnmuteActorInput()
        {
            this.Type = "app.bsky.graph.unmuteActor#UnmuteActorInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteActorInput"/> class.
        /// </summary>
        public UnmuteActorInput(CBORObject obj)
        {
            if (obj["actor"] is not null) this.Actor = obj["actor"].ToATIdentifier();
        }

        /// <summary>
        /// Gets or sets the actor.
        /// </summary>
        [JsonPropertyName("actor")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATIdentifierJsonConverter))]
        public FishyFlip.Models.ATIdentifier Actor { get; set; }

        public const string RecordType = "app.bsky.graph.unmuteActor#UnmuteActorInput";

        public static UnmuteActorInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Graph.UnmuteActorInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Graph.UnmuteActorInput>)SourceGenerationContext.Default.AppBskyGraphUnmuteActorInput)!;
        }
    }
}

