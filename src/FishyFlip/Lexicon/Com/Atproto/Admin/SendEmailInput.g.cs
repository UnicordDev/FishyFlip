// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{
    public partial class SendEmailInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailInput"/> class.
        /// </summary>
        /// <param name="recipientDid"></param>
        /// <param name="content"></param>
        /// <param name="subject"></param>
        /// <param name="senderDid"></param>
        /// <param name="comment">Additional comment by the sender that won't be used in the email itself but helpful to provide more context for moderators/reviewers</param>
        public SendEmailInput(FishyFlip.Models.ATDid recipientDid = default, string content = default, string? subject = default, FishyFlip.Models.ATDid senderDid = default, string? comment = default)
        {
            this.RecipientDid = recipientDid;
            this.Content = content;
            this.Subject = subject;
            this.SenderDid = senderDid;
            this.Comment = comment;
            this.Type = "com.atproto.admin.sendEmail#SendEmailInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailInput"/> class.
        /// </summary>
        public SendEmailInput()
        {
            this.Type = "com.atproto.admin.sendEmail#SendEmailInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailInput"/> class.
        /// </summary>
        public SendEmailInput(CBORObject obj)
        {
            if (obj["recipientDid"] is not null) this.RecipientDid = obj["recipientDid"].ToATDid();
            if (obj["content"] is not null) this.Content = obj["content"].AsString();
            if (obj["subject"] is not null) this.Subject = obj["subject"].AsString();
            if (obj["senderDid"] is not null) this.SenderDid = obj["senderDid"].ToATDid();
            if (obj["comment"] is not null) this.Comment = obj["comment"].AsString();
        }

        /// <summary>
        /// Gets or sets the recipientDid.
        /// </summary>
        [JsonPropertyName("recipientDid")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid RecipientDid { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [JsonPropertyName("content")]
        [JsonRequired]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the senderDid.
        /// </summary>
        [JsonPropertyName("senderDid")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid SenderDid { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// <br/> Additional comment by the sender that won't be used in the email itself but helpful to provide more context for moderators/reviewers
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        public const string RecordType = "com.atproto.admin.sendEmail#SendEmailInput";

        public static SendEmailInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Admin.SendEmailInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Admin.SendEmailInput>)SourceGenerationContext.Default.ComAtprotoAdminSendEmailInput)!;
        }
    }
}

