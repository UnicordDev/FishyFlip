// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class MessageView : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageView"/> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rev"></param>
        /// <param name="text"></param>
        /// <param name="facets">Annotations of text (mentions, URLs, hashtags, etc)</param>
        /// <param name="embed">
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef"/> (app.bsky.embed.record#view) <br/>
        /// </param>
        /// <param name="sender">
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageViewSender"/> (chat.bsky.convo.defs#messageViewSender)
        /// </param>
        /// <param name="sentAt"></param>
        public MessageView(string? id = default, string? rev = default, string? text = default, List<FishyFlip.Lexicon.App.Bsky.Richtext.Facet>? facets = default, FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef? embed = default, FishyFlip.Lexicon.Chat.Bsky.Convo.MessageViewSender? sender = default, DateTime? sentAt = default)
        {
            this.Id = id;
            this.Rev = rev;
            this.Text = text;
            this.Facets = facets;
            this.Embed = embed;
            this.Sender = sender;
            this.SentAt = sentAt;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageView"/> class.
        /// </summary>
        public MessageView()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageView"/> class.
        /// </summary>
        public MessageView(CBORObject obj)
        {
            if (obj["id"] is not null) this.Id = obj["id"].AsString();
            if (obj["rev"] is not null) this.Rev = obj["rev"].AsString();
            if (obj["text"] is not null) this.Text = obj["text"].AsString();
            if (obj["facets"] is not null) this.Facets = obj["facets"].Values.Select(n =>new FishyFlip.Lexicon.App.Bsky.Richtext.Facet(n)).ToList();
            if (obj["embed"] is not null) this.Embed = new FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef(obj["embed"]);
            if (obj["sender"] is not null) this.Sender = new FishyFlip.Lexicon.Chat.Bsky.Convo.MessageViewSender(obj["sender"]);
            if (obj["sentAt"] is not null) this.SentAt = obj["sentAt"].ToDateTime();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        [JsonRequired]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the rev.
        /// </summary>
        [JsonPropertyName("rev")]
        [JsonRequired]
        public string? Rev { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [JsonPropertyName("text")]
        [JsonRequired]
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the facets.
        /// <br/> Annotations of text (mentions, URLs, hashtags, etc)
        /// </summary>
        [JsonPropertyName("facets")]
        public List<FishyFlip.Lexicon.App.Bsky.Richtext.Facet>? Facets { get; set; }

        /// <summary>
        /// Gets or sets the embed.
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef"/> (app.bsky.embed.record#view) <br/>
        /// </summary>
        [JsonPropertyName("embed")]
        public FishyFlip.Lexicon.App.Bsky.Embed.ViewRecordDef? Embed { get; set; }

        /// <summary>
        /// Gets or sets the sender.
        /// <br/> <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageViewSender"/> (chat.bsky.convo.defs#messageViewSender)
        /// </summary>
        [JsonPropertyName("sender")]
        [JsonRequired]
        public FishyFlip.Lexicon.Chat.Bsky.Convo.MessageViewSender? Sender { get; set; }

        /// <summary>
        /// Gets or sets the sentAt.
        /// </summary>
        [JsonPropertyName("sentAt")]
        [JsonRequired]
        public DateTime? SentAt { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.defs#messageView";

        public const string RecordType = "chat.bsky.convo.defs#messageView";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Chat.Bsky.Convo.MessageView>(this, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.MessageView>)SourceGenerationContext.Default.ChatBskyConvoMessageView)!;
        }

        public static MessageView FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Chat.Bsky.Convo.MessageView>(json, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.MessageView>)SourceGenerationContext.Default.ChatBskyConvoMessageView)!;
        }
    }
}

