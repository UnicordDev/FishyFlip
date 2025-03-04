// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Server
{
    public partial class Links : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Links"/> class.
        /// </summary>
        /// <param name="privacyPolicy"></param>
        /// <param name="termsOfService"></param>
        public Links(string? privacyPolicy = default, string? termsOfService = default)
        {
            this.PrivacyPolicy = privacyPolicy;
            this.TermsOfService = termsOfService;
            this.Type = "com.atproto.server.describeServer#links";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Links"/> class.
        /// </summary>
        public Links()
        {
            this.Type = "com.atproto.server.describeServer#links";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Links"/> class.
        /// </summary>
        public Links(CBORObject obj)
        {
            if (obj["privacyPolicy"] is not null) this.PrivacyPolicy = obj["privacyPolicy"].AsString();
            if (obj["termsOfService"] is not null) this.TermsOfService = obj["termsOfService"].AsString();
        }

        /// <summary>
        /// Gets or sets the privacyPolicy.
        /// </summary>
        [JsonPropertyName("privacyPolicy")]
        public string? PrivacyPolicy { get; set; }

        /// <summary>
        /// Gets or sets the termsOfService.
        /// </summary>
        [JsonPropertyName("termsOfService")]
        public string? TermsOfService { get; set; }

        public const string RecordType = "com.atproto.server.describeServer#links";

        public static Links FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Server.Links>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Server.Links>)SourceGenerationContext.Default.ComAtprotoServerLinks)!;
        }
    }
}

