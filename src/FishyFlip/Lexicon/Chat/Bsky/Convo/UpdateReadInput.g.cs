// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class UpdateReadInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReadInput"/> class.
        /// </summary>
        /// <param name="convoId"></param>
        /// <param name="messageId"></param>
        public UpdateReadInput(string convoId = default, string? messageId = default)
        {
            this.ConvoId = convoId;
            this.MessageId = messageId;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReadInput"/> class.
        /// </summary>
        public UpdateReadInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReadInput"/> class.
        /// </summary>
        public UpdateReadInput(CBORObject obj)
        {
            if (obj["convoId"] is not null) this.ConvoId = obj["convoId"].AsString();
            if (obj["messageId"] is not null) this.MessageId = obj["messageId"].AsString();
        }

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
        public string? MessageId { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.updateRead#UpdateReadInput";

        public const string RecordType = "chat.bsky.convo.updateRead#UpdateReadInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Chat.Bsky.Convo.UpdateReadInput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.UpdateReadInput>)SourceGenerationContext.Default.ChatBskyConvoUpdateReadInput)!;
        }

        public static UpdateReadInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Chat.Bsky.Convo.UpdateReadInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Chat.Bsky.Convo.UpdateReadInput>)SourceGenerationContext.Default.ChatBskyConvoUpdateReadInput)!;
        }
    }
}

