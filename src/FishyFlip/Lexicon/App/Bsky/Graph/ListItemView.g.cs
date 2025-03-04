// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.App.Bsky.Graph
{
    public partial class ListItemView : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemView"/> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="subject">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ProfileView"/> (app.bsky.actor.defs#profileView)
        /// </param>
        public ListItemView(FishyFlip.Models.ATUri uri = default, FishyFlip.Lexicon.App.Bsky.Actor.ProfileView subject = default)
        {
            this.Uri = uri;
            this.Subject = subject;
            this.Type = "app.bsky.graph.defs#listItemView";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemView"/> class.
        /// </summary>
        public ListItemView()
        {
            this.Type = "app.bsky.graph.defs#listItemView";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemView"/> class.
        /// </summary>
        public ListItemView(CBORObject obj)
        {
            if (obj["uri"] is not null) this.Uri = obj["uri"].ToATUri();
            if (obj["subject"] is not null) this.Subject = new FishyFlip.Lexicon.App.Bsky.Actor.ProfileView(obj["subject"]);
        }

        /// <summary>
        /// Gets or sets the uri.
        /// </summary>
        [JsonPropertyName("uri")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATUriJsonConverter))]
        public FishyFlip.Models.ATUri Uri { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ProfileView"/> (app.bsky.actor.defs#profileView)
        /// </summary>
        [JsonPropertyName("subject")]
        [JsonRequired]
        public FishyFlip.Lexicon.App.Bsky.Actor.ProfileView Subject { get; set; }

        public const string RecordType = "app.bsky.graph.defs#listItemView";

        public static ListItemView FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Graph.ListItemView>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Graph.ListItemView>)SourceGenerationContext.Default.AppBskyGraphListItemView)!;
        }
    }
}

