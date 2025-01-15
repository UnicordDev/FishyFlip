// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class SendMessageInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageInput"/> class.
        /// </summary>
        /// <param name="convoId"></param>
        /// <param name="message">
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput"/> (chat.bsky.convo.defs#messageInput)
        /// </param>
        public SendMessageInput(string? convoId = default, FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput? message = default)
        {
            this.ConvoId = convoId;
            this.Message = message;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageInput"/> class.
        /// </summary>
        public SendMessageInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendMessageInput"/> class.
        /// </summary>
        public SendMessageInput(CBORObject obj)
        {
            if (obj["convoId"] is not null) this.ConvoId = obj["convoId"].AsString();
            if (obj["message"] is not null) this.Message = new FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput(obj["message"]);
        }

        /// <summary>
        /// Gets or sets the convoId.
        /// </summary>
        [JsonPropertyName("convoId")]
        [JsonRequired]
        public string? ConvoId { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// <br/> <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput"/> (chat.bsky.convo.defs#messageInput)
        /// </summary>
        [JsonPropertyName("message")]
        [JsonRequired]
        public FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput? Message { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.sendMessage#SendMessageInput";

        public const string RecordType = "chat.bsky.convo.sendMessage#SendMessageInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Chat.Bsky.Convo.SendMessageInput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.SendMessageInput>)SourceGenerationContext.Default.ChatBskyConvoSendMessageInput)!;
        }

        public static SendMessageInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Chat.Bsky.Convo.SendMessageInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.SendMessageInput>)SourceGenerationContext.Default.ChatBskyConvoSendMessageInput)!;
        }
    }
}

