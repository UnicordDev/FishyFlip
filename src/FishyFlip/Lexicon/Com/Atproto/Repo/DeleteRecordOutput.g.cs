// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Com.Atproto.Repo
{
    public partial class DeleteRecordOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRecordOutput"/> class.
        /// </summary>
        /// <param name="commit">
        /// <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta"/> (com.atproto.repo.defs#commitMeta)
        /// </param>
        public DeleteRecordOutput(FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta? commit = default)
        {
            this.Commit = commit;
            this.Type = "com.atproto.repo.deleteRecord#DeleteRecordOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRecordOutput"/> class.
        /// </summary>
        public DeleteRecordOutput()
        {
            this.Type = "com.atproto.repo.deleteRecord#DeleteRecordOutput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRecordOutput"/> class.
        /// </summary>
        public DeleteRecordOutput(CBORObject obj)
        {
            if (obj["commit"] is not null) this.Commit = new FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta(obj["commit"]);
        }

        /// <summary>
        /// Gets or sets the commit.
        /// <br/> <see cref="FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta"/> (com.atproto.repo.defs#commitMeta)
        /// </summary>
        [JsonPropertyName("commit")]
        public FishyFlip.Lexicon.Com.Atproto.Repo.CommitMeta? Commit { get; set; }

        public const string RecordType = "com.atproto.repo.deleteRecord#DeleteRecordOutput";

        public static DeleteRecordOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Com.Atproto.Repo.DeleteRecordOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Com.Atproto.Repo.DeleteRecordOutput>)SourceGenerationContext.Default.ComAtprotoRepoDeleteRecordOutput)!;
        }
    }
}

