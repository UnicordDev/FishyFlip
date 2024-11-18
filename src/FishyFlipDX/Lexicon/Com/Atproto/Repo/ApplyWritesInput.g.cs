// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    public partial class ApplyWritesInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyWritesInput"/> class.
        /// </summary>
        public ApplyWritesInput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyWritesInput"/> class.
        /// </summary>
        public ApplyWritesInput(CBORObject obj)
        {
            if (obj["repo"] is not null) this.Repo = obj["repo"].ToATIdentifier();
            if (obj["validate"] is not null) this.Validate = obj["validate"].AsBoolean();
            if (obj["writes"] is not null) this.Writes = obj["writes"].Values.Select(n => n is not null ? n.ToATObject() : null).ToList();
            if (obj["swapCommit"] is not null) this.SwapCommit = obj["swapCommit"].AsString();
        }

        /// <summary>
        /// The handle or DID of the repo (aka, current account).
        /// </summary>
        [JsonPropertyName("repo")]
        [JsonRequired]
        public FishyFlip.Models.ATIdentifier? Repo { get; set; }

        /// <summary>
        /// Can be set to 'false' to skip Lexicon schema validation of record data across all operations, 'true' to require it, or leave unset to validate only for known Lexicons.
        /// </summary>
        [JsonPropertyName("validate")]
        public bool? Validate { get; set; }

        [JsonPropertyName("writes")]
        [JsonRequired]
        public List<ATObject?>? Writes { get; set; }

        /// <summary>
        /// If provided, the entire operation will fail if the current repo commit CID does not match this value. Used to prevent conflicting repo mutations.
        /// </summary>
        [JsonPropertyName("swapCommit")]
        public string? SwapCommit { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "com.atproto.repo.applyWrites#ApplyWritesInput";

        public const string RecordType = "com.atproto.repo.applyWrites#ApplyWritesInput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Com.Atproto.Repo.ApplyWritesInput>(this, (JsonTypeInfo<Com.Atproto.Repo.ApplyWritesInput>)SourceGenerationContext.Default.ComAtprotoRepoApplyWritesInput)!;
        }

        public static ApplyWritesInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Com.Atproto.Repo.ApplyWritesInput>(json, (JsonTypeInfo<Com.Atproto.Repo.ApplyWritesInput>)SourceGenerationContext.Default.ComAtprotoRepoApplyWritesInput)!;
        }
    }
}

