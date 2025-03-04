// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class GetAccountInviteCodesOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInviteCodesOutput"/> class.
        /// </summary>
        /// <param name="codes"></param>
        public GetAccountInviteCodesOutput(List<FishyFlip.Lexicon.Com.Atproto.Server.InviteCode> codes = default)
        {
            this.Codes = codes;
            this.Type = "com.atproto.server.getAccountInviteCodes#GetAccountInviteCodesOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInviteCodesOutput"/> class.
        /// </summary>
        public GetAccountInviteCodesOutput()
        {
            this.Type = "com.atproto.server.getAccountInviteCodes#GetAccountInviteCodesOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountInviteCodesOutput"/> class.
        /// </summary>
        public GetAccountInviteCodesOutput(CBORObject obj)
        {
            if (obj["codes"] is not null) this.Codes = obj["codes"].Values.Select(n =>new FishyFlip.Lexicon.Com.Atproto.Server.InviteCode(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the codes.
        /// </summary>
        [JsonPropertyName("codes")]
        [JsonRequired]
        public List<FishyFlip.Lexicon.Com.Atproto.Server.InviteCode> Codes { get; set; }

        public const string RecordType = "com.atproto.server.getAccountInviteCodes#GetAccountInviteCodesOutput";

        public static GetAccountInviteCodesOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Server.GetAccountInviteCodesOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.GetAccountInviteCodesOutput>)SourceGenerationContext.Default.ComAtprotoServerGetAccountInviteCodesOutput)!;
        }
    }
}

