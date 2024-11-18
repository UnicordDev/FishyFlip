// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    /// <summary>
    /// Account login session returned on successful account creation.
    /// </summary>
    public partial class CreateAccountOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountOutput"/> class.
        /// </summary>
        public CreateAccountOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountOutput"/> class.
        /// </summary>
        public CreateAccountOutput(CBORObject obj)
        {
            if (obj["accessJwt"] is not null) this.AccessJwt = obj["accessJwt"].AsString();
            if (obj["refreshJwt"] is not null) this.RefreshJwt = obj["refreshJwt"].AsString();
            if (obj["handle"] is not null) this.Handle = obj["handle"].ToATHandle();
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
            // Ignore DidDoc
        }

        [JsonPropertyName("accessJwt")]
        [JsonRequired]
        public string? AccessJwt { get; set; }

        [JsonPropertyName("refreshJwt")]
        [JsonRequired]
        public string? RefreshJwt { get; set; }

        [JsonPropertyName("handle")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATHandleJsonConverter))]
        public FishyFlip.Models.ATHandle? Handle { get; set; }

        /// <summary>
        /// The DID of the new account.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        /// <summary>
        /// Complete DID document.
        /// </summary>
        [JsonPropertyName("didDoc")]
        public FishyFlip.Models.DidDoc? DidDoc { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.server.createAccount#CreateAccountOutput";

        public const string RecordType = "com.atproto.server.createAccount#CreateAccountOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Server.CreateAccountOutput>(this, (JsonTypeInfo<Com.Atproto.Server.CreateAccountOutput>)SourceGenerationContext.Default.ComAtprotoServerCreateAccountOutput)!;
        }

        public static CreateAccountOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Server.CreateAccountOutput>(json, (JsonTypeInfo<Com.Atproto.Server.CreateAccountOutput>)SourceGenerationContext.Default.ComAtprotoServerCreateAccountOutput)!;
        }
    }
}

