// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Identity
{
    public partial class SubmitPlcOperationInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPlcOperationInput"/> class.
        /// </summary>
        /// <param name="operation"></param>
        public SubmitPlcOperationInput(ATObject? operation = default)
        {
            this.Operation = operation;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPlcOperationInput"/> class.
        /// </summary>
        public SubmitPlcOperationInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPlcOperationInput"/> class.
        /// </summary>
        public SubmitPlcOperationInput(CBORObject obj)
        {
            if (obj["operation"] is not null) this.Operation = obj["operation"].ToATObject();
        }

        /// <summary>
        /// Gets or sets the operation.
        /// </summary>
        [JsonPropertyName("operation")]
        [JsonRequired]
        public ATObject? Operation { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.identity.submitPlcOperation#SubmitPlcOperationInput";

        public const string RecordType = "com.atproto.identity.submitPlcOperation#SubmitPlcOperationInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Identity.SubmitPlcOperationInput>(this, (JsonTypeInfo<Com.Atproto.Identity.SubmitPlcOperationInput>)SourceGenerationContext.Default.ComAtprotoIdentitySubmitPlcOperationInput)!;
        }

        public static SubmitPlcOperationInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Identity.SubmitPlcOperationInput>(json, (JsonTypeInfo<Com.Atproto.Identity.SubmitPlcOperationInput>)SourceGenerationContext.Default.ComAtprotoIdentitySubmitPlcOperationInput)!;
        }
    }
}

