// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class BatchItem : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItem"/> class.
        /// </summary>
        /// <param name="convoId"></param>
        /// <param name="message">
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput"/> (chat.bsky.convo.defs#messageInput)
        /// </param>
        public BatchItem(string convoId = default, FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput message = default)
        {
            this.ConvoId = convoId;
            this.Message = message;
            this.Type = "chat.bsky.convo.sendMessageBatch#batchItem";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItem"/> class.
        /// </summary>
        public BatchItem()
        {
            this.Type = "chat.bsky.convo.sendMessageBatch#batchItem";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItem"/> class.
        /// </summary>
        public BatchItem(CBORObject obj)
        {
            if (obj["convoId"] is not null) this.ConvoId = obj["convoId"].AsString();
            if (obj["message"] is not null) this.Message = new FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput(obj["message"]);
        }

        /// <summary>
        /// Gets or sets the convoId.
        /// </summary>
        [JsonPropertyName("convoId")]
        [JsonRequired]
        public string ConvoId { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// <br/> <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput"/> (chat.bsky.convo.defs#messageInput)
        /// </summary>
        [JsonPropertyName("message")]
        [JsonRequired]
        public FishyFlip.Lexicon.Chat.Bsky.Convo.MessageInput Message { get; set; }

        public const string RecordType = "chat.bsky.convo.sendMessageBatch#batchItem";

        public static BatchItem FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Chat.Bsky.Convo.BatchItem>(json, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.BatchItem>)SourceGenerationContext.Default.ChatBskyConvoBatchItem)!;
        }
    }
}

