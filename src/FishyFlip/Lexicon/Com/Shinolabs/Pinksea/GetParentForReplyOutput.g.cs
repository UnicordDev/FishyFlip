// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Shinolabs.Pinksea
{
    public partial class GetParentForReplyOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetParentForReplyOutput"/> class.
        /// </summary>
        /// <param name="did">The DID of the author.</param>
        /// <param name="rkey">The record key.</param>
        public GetParentForReplyOutput(FishyFlip.Models.ATIdentifier? did = default, string? rkey = default)
        {
            this.Did = did;
            this.Rkey = rkey;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetParentForReplyOutput"/> class.
        /// </summary>
        public GetParentForReplyOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetParentForReplyOutput"/> class.
        /// </summary>
        public GetParentForReplyOutput(CBORObject obj)
        {
            if (obj["did"] is not null) this.Did = obj["did"].ToATIdentifier();
            if (obj["rkey"] is not null) this.Rkey = obj["rkey"].AsString();
        }

        /// <summary>
        /// Gets or sets the did.
        /// <br/> The DID of the author.
        /// </summary>
        [JsonPropertyName("did")]
        [JsonRequired]
        [JsonConverter(typeof(FishyFlip.Tools.Json.ATIdentifierJsonConverter))]
        public FishyFlip.Models.ATIdentifier? Did { get; set; }

        /// <summary>
        /// Gets or sets the rkey.
        /// <br/> The record key.
        /// </summary>
        [JsonPropertyName("rkey")]
        [JsonRequired]
        public string? Rkey { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.shinolabs.pinksea.getParentForReply#GetParentForReplyOutput";

        public const string RecordType = "com.shinolabs.pinksea.getParentForReply#GetParentForReplyOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Com.Shinolabs.Pinksea.GetParentForReplyOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Com.Shinolabs.Pinksea.GetParentForReplyOutput>)SourceGenerationContext.Default.ComShinolabsPinkseaGetParentForReplyOutput)!;
        }

        public static GetParentForReplyOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Shinolabs.Pinksea.GetParentForReplyOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Shinolabs.Pinksea.GetParentForReplyOutput>)SourceGenerationContext.Default.ComShinolabsPinkseaGetParentForReplyOutput)!;
        }
    }
}

