// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    /// <summary>
    /// Operation which updates an existing record.
    /// </summary>
    public partial class Update : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Update"/> class.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="rkey"></param>
        /// <param name="value"></param>
        public Update(string? collection = default, string? rkey = default, ATObject? value = default)
        {
            this.Collection = collection;
            this.Rkey = rkey;
            this.Value = value;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Update"/> class.
        /// </summary>
        public Update()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Update"/> class.
        /// </summary>
        public Update(CBORObject obj)
        {
            if (obj["collection"] is not null) this.Collection = obj["collection"].AsString();
            if (obj["rkey"] is not null) this.Rkey = obj["rkey"].AsString();
            if (obj["value"] is not null) this.Value = obj["value"].ToATObject();
        }

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        [JsonPropertyName("collection")]
        [JsonRequired]
        public string? Collection { get; set; }

        /// <summary>
        /// Gets or sets the rkey.
        /// </summary>
        [JsonPropertyName("rkey")]
        [JsonRequired]
        public string? Rkey { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")]
        [JsonRequired]
        public ATObject? Value { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.repo.applyWrites#update";

        public const string RecordType = "com.atproto.repo.applyWrites#update";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Com.Atproto.Repo.Update>(this, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Repo.Update>)SourceGenerationContext.Default.ComAtprotoRepoUpdate)!;
        }

        public static Update FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Repo.Update>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Repo.Update>)SourceGenerationContext.Default.ComAtprotoRepoUpdate)!;
        }
    }
}

