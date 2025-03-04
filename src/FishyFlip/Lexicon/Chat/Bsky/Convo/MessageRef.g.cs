// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class MessageRef : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRef"/> class.
        /// </summary>
        /// <param name="did"></param>
        /// <param name="convoId"></param>
        /// <param name="messageId"></param>
        public MessageRef(FishyFlip.Models.ATDid did = default, string convoId = default, string messageId = default)
        {
            this.Did = did;
            this.ConvoId = convoId;
            this.MessageId = messageId;
            this.Type = "chat.bsky.convo.defs#messageRef";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRef"/> class.
        /// </summary>
        public MessageRef()
        {
            this.Type = "chat.bsky.convo.defs#messageRef";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MessageRef"/> class.
        /// </summary>
        public MessageRef(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["convoId"] is not null) this.ConvoId = obj["convoId"].AsString();
            if (obj["messageId"] is not null) this.MessageId = obj["messageId"].AsString();
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid Did { get; set; }

        /// <summary>
        /// Gets or sets the convoId.
        /// </summary>
        [JsonPropertyName("convoId")]
        [JsonRequired]
        public string ConvoId { get; set; }

        /// <summary>
        /// Gets or sets the messageId.
        /// </summary>
        [JsonPropertyName("messageId")]
        [JsonRequired]
        public string MessageId { get; set; }

        public const string RecordType = "chat.bsky.convo.defs#messageRef";

        public static MessageRef FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Chat.Bsky.Convo.MessageRef>(json, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.MessageRef>)SourceGenerationContext.Default.ChatBskyConvoMessageRef)!;
        }
    }
}

