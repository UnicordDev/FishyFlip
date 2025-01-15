// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.App.Bsky.Actor
{
    public partial class ProfileAssociated : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAssociated"/> class.
        /// </summary>
        /// <param name="lists"></param>
        /// <param name="feedgens"></param>
        /// <param name="starterPacks"></param>
        /// <param name="labeler"></param>
        /// <param name="chat">
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociatedChat"/> (app.bsky.actor.defs#profileAssociatedChat)
        /// </param>
        public ProfileAssociated(long? lists = default, long? feedgens = default, long? starterPacks = default, bool? labeler = default, FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociatedChat? chat = default)
        {
            this.Lists = lists;
            this.Feedgens = feedgens;
            this.StarterPacks = starterPacks;
            this.Labeler = labeler;
            this.Chat = chat;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAssociated"/> class.
        /// </summary>
        public ProfileAssociated()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAssociated"/> class.
        /// </summary>
        public ProfileAssociated(CBORObject obj)
        {
            if (obj["lists"] is not null) this.Lists = obj["lists"].AsInt64Value();
            if (obj["feedgens"] is not null) this.Feedgens = obj["feedgens"].AsInt64Value();
            if (obj["starterPacks"] is not null) this.StarterPacks = obj["starterPacks"].AsInt64Value();
            if (obj["labeler"] is not null) this.Labeler = obj["labeler"].AsBoolean();
            if (obj["chat"] is not null) this.Chat = new FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociatedChat(obj["chat"]);
        }

        /// <summary>
        /// Gets or sets the lists.
        /// </summary>
        [JsonPropertyName("lists")]
        public long? Lists { get; set; }

        /// <summary>
        /// Gets or sets the feedgens.
        /// </summary>
        [JsonPropertyName("feedgens")]
        public long? Feedgens { get; set; }

        /// <summary>
        /// Gets or sets the starterPacks.
        /// </summary>
        [JsonPropertyName("starterPacks")]
        public long? StarterPacks { get; set; }

        /// <summary>
        /// Gets or sets the labeler.
        /// </summary>
        [JsonPropertyName("labeler")]
        public bool? Labeler { get; set; }

        /// <summary>
        /// Gets or sets the chat.
        /// <br/> <see cref="FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociatedChat"/> (app.bsky.actor.defs#profileAssociatedChat)
        /// </summary>
        [JsonPropertyName("chat")]
        public FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociatedChat? Chat { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "app.bsky.actor.defs#profileAssociated";

        public const string RecordType = "app.bsky.actor.defs#profileAssociated";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociated>(this, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociated>)SourceGenerationContext.Default.AppBskyActorProfileAssociated)!;
        }

        public static ProfileAssociated FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociated>(json, (JsonTypeInfo<FishyFlip.Lexicon.App.Bsky.Actor.ProfileAssociated>)SourceGenerationContext.Default.AppBskyActorProfileAssociated)!;
        }
    }
}

