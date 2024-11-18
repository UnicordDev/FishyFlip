// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{
    public partial class UpdateAccountPasswordInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountPasswordInput"/> class.
        /// </summary>
        public UpdateAccountPasswordInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccountPasswordInput"/> class.
        /// </summary>
        public UpdateAccountPasswordInput(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            if (obj["password"] is not null) this.Password = obj["password"].AsString();
        }

        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        [JsonPropertyName("password")]
        [JsonRequired]
        public string? Password { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.admin.updateAccountPassword#UpdateAccountPasswordInput";

        public const string RecordType = "com.atproto.admin.updateAccountPassword#UpdateAccountPasswordInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Admin.UpdateAccountPasswordInput>(this, (JsonTypeInfo<Com.Atproto.Admin.UpdateAccountPasswordInput>)SourceGenerationContext.Default.ComAtprotoAdminUpdateAccountPasswordInput)!;
        }

        public static UpdateAccountPasswordInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Admin.UpdateAccountPasswordInput>(json, (JsonTypeInfo<Com.Atproto.Admin.UpdateAccountPasswordInput>)SourceGenerationContext.Default.ComAtprotoAdminUpdateAccountPasswordInput)!;
        }
    }
}

