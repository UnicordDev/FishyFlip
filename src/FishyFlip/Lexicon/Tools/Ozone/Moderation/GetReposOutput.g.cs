// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Tools.Ozone.Moderation
{
    public partial class GetReposOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReposOutput"/> class.
        /// </summary>
        /// <param name="repos">
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.Tools.Ozone.Moderation.RepoViewDetail"/> (tools.ozone.moderation.defs#repoViewDetail) <br/>
        /// <see cref="FishyFlip.Lexicon.Tools.Ozone.Moderation.RepoViewNotFound"/> (tools.ozone.moderation.defs#repoViewNotFound) <br/>
        /// </param>
        public GetReposOutput(List<ATObject>? repos = default)
        {
            this.Repos = repos;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetReposOutput"/> class.
        /// </summary>
        public GetReposOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetReposOutput"/> class.
        /// </summary>
        public GetReposOutput(CBORObject obj)
        {
            if (obj["repos"] is not null) this.Repos = obj["repos"].Values.Select(n =>n.ToATObject()).ToList();
        }

        /// <summary>
        /// Gets or sets the repos.
        /// <br/> Union Types: <br/>
        /// <see cref="FishyFlip.Lexicon.Tools.Ozone.Moderation.RepoViewDetail"/> (tools.ozone.moderation.defs#repoViewDetail) <br/>
        /// <see cref="FishyFlip.Lexicon.Tools.Ozone.Moderation.RepoViewNotFound"/> (tools.ozone.moderation.defs#repoViewNotFound) <br/>
        /// </summary>
        [JsonPropertyName("repos")]
        [JsonRequired]
        public List<ATObject>? Repos { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "tools.ozone.moderation.getRepos#GetReposOutput";

        public const string RecordType = "tools.ozone.moderation.getRepos#GetReposOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Tools.Ozone.Moderation.GetReposOutput>(this, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Moderation.GetReposOutput>)SourceGenerationContext.Default.ToolsOzoneModerationGetReposOutput)!;
        }

        public static GetReposOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Tools.Ozone.Moderation.GetReposOutput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Moderation.GetReposOutput>)SourceGenerationContext.Default.ToolsOzoneModerationGetReposOutput)!;
        }
    }
}

