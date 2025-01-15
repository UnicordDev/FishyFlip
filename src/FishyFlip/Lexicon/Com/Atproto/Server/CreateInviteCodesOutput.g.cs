// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class CreateInviteCodesOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteCodesOutput"/> class.
        /// </summary>
        /// <param name="codes"></param>
        public CreateInviteCodesOutput(List<FishyFlip.Lexicon.Com.Atproto.Server.AccountCodes> codes = default)
        {
            this.Codes = codes;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteCodesOutput"/> class.
        /// </summary>
        public CreateInviteCodesOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteCodesOutput"/> class.
        /// </summary>
        public CreateInviteCodesOutput(CBORObject obj)
        {
            if (obj["codes"] is not null) this.Codes = obj["codes"].Values.Select(n =>new FishyFlip.Lexicon.Com.Atproto.Server.AccountCodes(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the codes.
        /// </summary>
        [JsonPropertyName("codes")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.Com.Atproto.Server.AccountCodes> Codes { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.server.createInviteCodes#CreateInviteCodesOutput";

        public const string RecordType = "com.atproto.server.createInviteCodes#CreateInviteCodesOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesOutput>)SourceGenerationContext.Default.ComAtprotoServerCreateInviteCodesOutput)!;
        }

        public static CreateInviteCodesOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesOutput>)SourceGenerationContext.Default.ComAtprotoServerCreateInviteCodesOutput)!;
        }
    }
}

