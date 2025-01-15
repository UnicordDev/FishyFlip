// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class UpdateEmailInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmailInput"/> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="emailAuthFactor"></param>
        /// <param name="token">Requires a token from com.atproto.sever.requestEmailUpdate if the account's email has been confirmed.</param>
        public UpdateEmailInput(string? email = default, bool? emailAuthFactor = default, string? token = default)
        {
            this.Email = email;
            this.EmailAuthFactor = emailAuthFactor;
            this.Token = token;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmailInput"/> class.
        /// </summary>
        public UpdateEmailInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEmailInput"/> class.
        /// </summary>
        public UpdateEmailInput(CBORObject obj)
        {
            if (obj["email"] is not null) this.Email = obj["email"].AsString();
            if (obj["emailAuthFactor"] is not null) this.EmailAuthFactor = obj["emailAuthFactor"].AsBoolean();
            if (obj["token"] is not null) this.Token = obj["token"].AsString();
        }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [JsonPropertyName("email")]
        [JsonRequired]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the emailAuthFactor.
        /// </summary>
        [JsonPropertyName("emailAuthFactor")]
        public bool? EmailAuthFactor { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// <br/> Requires a token from com.atproto.sever.requestEmailUpdate if the account's email has been confirmed.
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.server.updateEmail#UpdateEmailInput";

        public const string RecordType = "com.atproto.server.updateEmail#UpdateEmailInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Com.Atproto.Server.UpdateEmailInput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.UpdateEmailInput>)SourceGenerationContext.Default.ComAtprotoServerUpdateEmailInput)!;
        }

        public static UpdateEmailInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Server.UpdateEmailInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.UpdateEmailInput>)SourceGenerationContext.Default.ComAtprotoServerUpdateEmailInput)!;
        }
    }
}

