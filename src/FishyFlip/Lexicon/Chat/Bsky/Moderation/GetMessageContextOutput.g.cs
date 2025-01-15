// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Moderation
{
    public partial class GetMessageContextOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessageContextOutput"/> class.
        /// </summary>
        /// <param name="messages">
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageView"/> (chat.bsky.convo.defs#messageView) <br/>
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.DeletedMessageView"/> (chat.bsky.convo.defs#deletedMessageView) <br/>
        /// </param>
        public GetMessageContextOutput(List<ATObject>? messages = default)
        {
            this.Messages = messages;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessageContextOutput"/> class.
        /// </summary>
        public GetMessageContextOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetMessageContextOutput"/> class.
        /// </summary>
        public GetMessageContextOutput(CBORObject obj)
        {
            if (obj["messages"] is not null) this.Messages = obj["messages"].Values.Select(n =>n.ToATObject()).ToList();
        }

        /// <summary>
        /// Gets or sets the messages.
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.MessageView"/> (chat.bsky.convo.defs#messageView) <br/>
        /// <see cref="FishyFlip.Lexicon.Chat.Bsky.Convo.DeletedMessageView"/> (chat.bsky.convo.defs#deletedMessageView) <br/>
        /// </summary>
        [JsonPropertyName("messages")]
        [JsonRequired]
        public List<ATObject>? Messages { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.moderation.getMessageContext#GetMessageContextOutput";

        public const string RecordType = "chat.bsky.moderation.getMessageContext#GetMessageContextOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Chat.Bsky.Moderation.GetMessageContextOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Moderation.GetMessageContextOutput>)SourceGenerationContext.Default.ChatBskyModerationGetMessageContextOutput)!;
        }

        public static GetMessageContextOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Chat.Bsky.Moderation.GetMessageContextOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Moderation.GetMessageContextOutput>)SourceGenerationContext.Default.ChatBskyModerationGetMessageContextOutput)!;
        }
    }
}

