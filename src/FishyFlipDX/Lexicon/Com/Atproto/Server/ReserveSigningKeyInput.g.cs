// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class ReserveSigningKeyInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveSigningKeyInput"/> class.
        /// </summary>
        public ReserveSigningKeyInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ReserveSigningKeyInput"/> class.
        /// </summary>
        public ReserveSigningKeyInput(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATDid();
        }

        /// <summary>
        /// The DID to reserve a key for.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATDidJsonConverter))]
        public FishyFlip.Models.ATDid? Did { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.server.reserveSigningKey#ReserveSigningKeyInput";

        public const string RecordType = "com.atproto.server.reserveSigningKey#ReserveSigningKeyInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Server.ReserveSigningKeyInput>(this, (JsonTypeInfo<Com.Atproto.Server.ReserveSigningKeyInput>)SourceGenerationContext.Default.ComAtprotoServerReserveSigningKeyInput)!;
        }

        public static ReserveSigningKeyInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Server.ReserveSigningKeyInput>(json, (JsonTypeInfo<Com.Atproto.Server.ReserveSigningKeyInput>)SourceGenerationContext.Default.ComAtprotoServerReserveSigningKeyInput)!;
        }
    }
}

