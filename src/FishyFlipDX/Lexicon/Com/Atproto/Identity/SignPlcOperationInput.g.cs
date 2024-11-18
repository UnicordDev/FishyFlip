// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Identity
{
    public partial class SignPlcOperationInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SignPlcOperationInput"/> class.
        /// </summary>
        public SignPlcOperationInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SignPlcOperationInput"/> class.
        /// </summary>
        public SignPlcOperationInput(CBORObject obj)
        {
            if (obj["token"] is not null) this.Token = obj["token"].AsString();
            if (obj["rotationKeys"] is not null) this.RotationKeys = obj["rotationKeys"].Values.Select(n => n is not null ? n.AsString() : default).ToList();
            if (obj["alsoKnownAs"] is not null) this.AlsoKnownAs = obj["alsoKnownAs"].Values.Select(n => n is not null ? n.AsString() : default).ToList();
            if (obj["verificationMethods"] is not null) this.VerificationMethods = obj["verificationMethods"].ToATObject();
            if (obj["services"] is not null) this.Services = obj["services"].ToATObject();
        }

        /// <summary>
        /// A token received through com.atproto.identity.requestPlcOperationSignature
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        [JsonPropertyName("rotationKeys")]
        public List<string?>? RotationKeys { get; set; }

        [JsonPropertyName("alsoKnownAs")]
        public List<string?>? AlsoKnownAs { get; set; }

        [JsonPropertyName("verificationMethods")]
        public ATObject? VerificationMethods { get; set; }

        [JsonPropertyName("services")]
        public ATObject? Services { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.identity.signPlcOperation#SignPlcOperationInput";

        public const string RecordType = "com.atproto.identity.signPlcOperation#SignPlcOperationInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Identity.SignPlcOperationInput>(this, (JsonTypeInfo<Com.Atproto.Identity.SignPlcOperationInput>)SourceGenerationContext.Default.ComAtprotoIdentitySignPlcOperationInput)!;
        }

        public static SignPlcOperationInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Identity.SignPlcOperationInput>(json, (JsonTypeInfo<Com.Atproto.Identity.SignPlcOperationInput>)SourceGenerationContext.Default.ComAtprotoIdentitySignPlcOperationInput)!;
        }
    }
}

