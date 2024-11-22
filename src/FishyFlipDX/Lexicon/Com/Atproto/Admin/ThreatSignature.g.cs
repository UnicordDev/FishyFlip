// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Admin
{
    public partial class ThreatSignature : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreatSignature"/> class.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        public ThreatSignature(string? property = default, string? value = default)
        {
            this.Property = property;
            this.Value = value;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ThreatSignature"/> class.
        /// </summary>
        public ThreatSignature()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ThreatSignature"/> class.
        /// </summary>
        public ThreatSignature(CBORObject obj)
        {
            if (obj["property"] is not null) this.Property = obj["property"].AsString();
            if (obj["value"] is not null) this.Value = obj["value"].AsString();
        }

        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        [JsonPropertyName("property")]
        [JsonRequired]
        public string? Property { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")]
        [JsonRequired]
        public string? Value { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.admin.defs#threatSignature";

        public const string RecordType = "com.atproto.admin.defs#threatSignature";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Admin.ThreatSignature>(this, (JsonTypeInfo<Com.Atproto.Admin.ThreatSignature>)SourceGenerationContext.Default.ComAtprotoAdminThreatSignature)!;
        }

        public static ThreatSignature FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Admin.ThreatSignature>(json, (JsonTypeInfo<Com.Atproto.Admin.ThreatSignature>)SourceGenerationContext.Default.ComAtprotoAdminThreatSignature)!;
        }
    }
}

