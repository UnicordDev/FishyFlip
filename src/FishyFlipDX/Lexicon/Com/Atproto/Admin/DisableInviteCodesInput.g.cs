// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{
    public partial class DisableInviteCodesInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DisableInviteCodesInput"/> class.
        /// </summary>
        public DisableInviteCodesInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DisableInviteCodesInput"/> class.
        /// </summary>
        public DisableInviteCodesInput(CBORObject obj)
        {
            if (obj["codes"] is not null) this.Codes = obj["codes"].Values.Select(n => n is not null ? n.AsString() : default).ToList();
            if (obj["accounts"] is not null) this.Accounts = obj["accounts"].Values.Select(n => n is not null ? n.AsString() : default).ToList();
        }

        [JsonPropertyName("codes")]
        public List<string?>? Codes { get; set; }

        [JsonPropertyName("accounts")]
        public List<string?>? Accounts { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.admin.disableInviteCodes#DisableInviteCodesInput";

        public const string RecordType = "com.atproto.admin.disableInviteCodes#DisableInviteCodesInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Admin.DisableInviteCodesInput>(this, (JsonTypeInfo<Com.Atproto.Admin.DisableInviteCodesInput>)SourceGenerationContext.Default.ComAtprotoAdminDisableInviteCodesInput)!;
        }

        public static DisableInviteCodesInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Admin.DisableInviteCodesInput>(json, (JsonTypeInfo<Com.Atproto.Admin.DisableInviteCodesInput>)SourceGenerationContext.Default.ComAtprotoAdminDisableInviteCodesInput)!;
        }
    }
}

