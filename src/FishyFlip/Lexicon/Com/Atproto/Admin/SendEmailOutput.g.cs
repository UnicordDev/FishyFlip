// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{
    public partial class SendEmailOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailOutput"/> class.
        /// </summary>
        /// <param name="sent"></param>
        public SendEmailOutput(bool sent = default)
        {
            this.Sent = sent;
            this.Type = "com.atproto.admin.sendEmail#SendEmailOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailOutput"/> class.
        /// </summary>
        public SendEmailOutput()
        {
            this.Type = "com.atproto.admin.sendEmail#SendEmailOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailOutput"/> class.
        /// </summary>
        public SendEmailOutput(CBORObject obj)
        {
            if (obj["sent"] is not null) this.Sent = obj["sent"].AsBoolean();
        }

        /// <summary>
        /// Gets or sets the sent.
        /// </summary>
        [JsonPropertyName("sent")]
        [JsonRequired]
        public bool Sent { get; set; }

        public const string RecordType = "com.atproto.admin.sendEmail#SendEmailOutput";

        public static SendEmailOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Admin.SendEmailOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Admin.SendEmailOutput>)SourceGenerationContext.Default.ComAtprotoAdminSendEmailOutput)!;
        }
    }
}

