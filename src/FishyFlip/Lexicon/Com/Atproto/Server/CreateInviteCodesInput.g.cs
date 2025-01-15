// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class CreateInviteCodesInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteCodesInput"/> class.
        /// </summary>
        /// <param name="codeCount"></param>
        /// <param name="useCount"></param>
        /// <param name="forAccounts"></param>
        public CreateInviteCodesInput(long codeCount = default, long useCount = default, List<FishyFlip.Models.ATDid>? forAccounts = default)
        {
            this.CodeCount = codeCount;
            this.UseCount = useCount;
            this.ForAccounts = forAccounts;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteCodesInput"/> class.
        /// </summary>
        public CreateInviteCodesInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInviteCodesInput"/> class.
        /// </summary>
        public CreateInviteCodesInput(CBORObject obj)
        {
            if (obj["codeCount"] is not null) this.CodeCount = obj["codeCount"].AsInt64Value();
            if (obj["useCount"] is not null) this.UseCount = obj["useCount"].AsInt64Value();
            if (obj["forAccounts"] is not null) this.ForAccounts = obj["forAccounts"].Values.Select(n =>n.ToATDid()!).ToList();
        }

        /// <summary>
        /// Gets or sets the codeCount.
        /// </summary>
        [JsonPropertyName("codeCount")]
        [JsonRequired]
        public long CodeCount { get; set; } = 1;

        /// <summary>
        /// Gets or sets the useCount.
        /// </summary>
        [JsonPropertyName("useCount")]
        [JsonRequired]
        public long UseCount { get; set; }

        /// <summary>
        /// Gets or sets the forAccounts.
        /// </summary>
        [JsonPropertyName("forAccounts")]
        public List<FishyFlip.Models.ATDid>? ForAccounts { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.server.createInviteCodes#CreateInviteCodesInput";

        public const string RecordType = "com.atproto.server.createInviteCodes#CreateInviteCodesInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesInput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesInput>)SourceGenerationContext.Default.ComAtprotoServerCreateInviteCodesInput)!;
        }

        public static CreateInviteCodesInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.CreateInviteCodesInput>)SourceGenerationContext.Default.ComAtprotoServerCreateInviteCodesInput)!;
        }
    }
}

