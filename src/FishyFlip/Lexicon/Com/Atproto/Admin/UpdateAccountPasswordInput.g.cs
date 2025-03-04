// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{
    public partial class UpdateAccountPasswordInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountPasswordInput"/> class.
        /// </summary>
        /// <param name="did"></param>
        /// <param name="password"></param>
        public UpdateAccountPasswordInput(FishyFlip.Models.ATDid did = default, string password = default)
        {
            this.Did = did;
            this.Password = password;
            this.Type = "com.atproto.admin.updateAccountPassword#UpdateAccountPasswordInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountPasswordInput"/> class.
        /// </summary>
        public UpdateAccountPasswordInput()
        {
            this.Type = "com.atproto.admin.updateAccountPassword#UpdateAccountPasswordInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountPasswordInput"/> class.
        /// </summary>
        public UpdateAccountPasswordInput(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["password"] is not null) this.Password = obj["password"].AsString();
        }

        /// <summary>
        /// Gets or sets the did.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid Did { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [JsonPropertyName("password")]
        [JsonRequired]
        public string Password { get; set; }

        public const string RecordType = "com.atproto.admin.updateAccountPassword#UpdateAccountPasswordInput";

        public static UpdateAccountPasswordInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Admin.UpdateAccountPasswordInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Admin.UpdateAccountPasswordInput>)SourceGenerationContext.Default.ComAtprotoAdminUpdateAccountPasswordInput)!;
        }
    }
}

