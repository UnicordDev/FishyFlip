// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class ReserveSigningKeyOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveSigningKeyOutput"/> class.
        /// </summary>
        /// <param name="signingKey">The public key for the reserved signing key, in did:key serialization.</param>
        public ReserveSigningKeyOutput(string? signingKey = default)
        {
            this.SigningKey = signingKey;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveSigningKeyOutput"/> class.
        /// </summary>
        public ReserveSigningKeyOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveSigningKeyOutput"/> class.
        /// </summary>
        public ReserveSigningKeyOutput(CBORObject obj)
        {
            if (obj["signingKey"] is not null) this.SigningKey = obj["signingKey"].AsString();
        }

        /// <summary>
        /// Gets or sets the signingKey.
        /// The public key for the reserved signing key, in did:key serialization.
        /// </summary>
        [JsonPropertyName("signingKey")]
        [JsonRequired]
        public string? SigningKey { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.server.reserveSigningKey#ReserveSigningKeyOutput";

        public const string RecordType = "com.atproto.server.reserveSigningKey#ReserveSigningKeyOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Server.ReserveSigningKeyOutput>(this, (JsonTypeInfo<Com.Atproto.Server.ReserveSigningKeyOutput>)SourceGenerationContext.Default.ComAtprotoServerReserveSigningKeyOutput)!;
        }

        public static ReserveSigningKeyOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Server.ReserveSigningKeyOutput>(json, (JsonTypeInfo<Com.Atproto.Server.ReserveSigningKeyOutput>)SourceGenerationContext.Default.ComAtprotoServerReserveSigningKeyOutput)!;
        }
    }
}

