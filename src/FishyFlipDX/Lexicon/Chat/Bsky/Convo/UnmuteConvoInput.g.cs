// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Chat.Bsky.Convo
{
    public partial class UnmuteConvoInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteConvoInput"/> class.
        /// </summary>
        /// <param name="convoId"></param>
        public UnmuteConvoInput(string? convoId = default)
        {
            this.ConvoId = convoId;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteConvoInput"/> class.
        /// </summary>
        public UnmuteConvoInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UnmuteConvoInput"/> class.
        /// </summary>
        public UnmuteConvoInput(CBORObject obj)
        {
            if (obj["convoId"] is not null) this.ConvoId = obj["convoId"].AsString();
        }

        /// <summary>
        /// Gets or sets the convoId.
        /// </summary>
        [JsonPropertyName("convoId")]
        [JsonRequired]
        public string? ConvoId { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "chat.bsky.convo.unmuteConvo#UnmuteConvoInput";

        public const string RecordType = "chat.bsky.convo.unmuteConvo#UnmuteConvoInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Chat.Bsky.Convo.UnmuteConvoInput>(this, (JsonTypeInfo<Chat.Bsky.Convo.UnmuteConvoInput>)SourceGenerationContext.Default.ChatBskyConvoUnmuteConvoInput)!;
        }

        public static UnmuteConvoInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Chat.Bsky.Convo.UnmuteConvoInput>(json, (JsonTypeInfo<Chat.Bsky.Convo.UnmuteConvoInput>)SourceGenerationContext.Default.ChatBskyConvoUnmuteConvoInput)!;
        }
    }
}

