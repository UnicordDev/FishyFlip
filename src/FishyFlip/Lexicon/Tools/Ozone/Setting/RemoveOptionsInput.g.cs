// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Tools.Ozone.Setting
{
    public partial class RemoveOptionsInput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOptionsInput"/> class.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="scope">
        /// <br/> Known Values: <br/>
        /// instance <br/>
        /// personal <br/>
        /// </param>
        public RemoveOptionsInput(List<string> keys = default, string scope = default)
        {
            this.Keys = keys;
            this.Scope = scope;
            this.Type = "tools.ozone.setting.removeOptions#RemoveOptionsInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOptionsInput"/> class.
        /// </summary>
        public RemoveOptionsInput()
        {
            this.Type = "tools.ozone.setting.removeOptions#RemoveOptionsInput";
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveOptionsInput"/> class.
        /// </summary>
        public RemoveOptionsInput(CBORObject obj)
        {
            if (obj["keys"] is not null) this.Keys = obj["keys"].Values.Select(n =>n.AsString()).ToList();
            if (obj["scope"] is not null) this.Scope = obj["scope"].AsString();
        }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        [JsonPropertyName("keys")]
        [JsonRequired]
        public List<string> Keys { get; set; }

        /// <summary>
        /// Gets or sets the scope.
        /// <br/> Known Values: <br/>
        /// instance <br/>
        /// personal <br/>
        /// </summary>
        [JsonPropertyName("scope")]
        [JsonRequired]
        public string Scope { get; set; }

        public const string RecordType = "tools.ozone.setting.removeOptions#RemoveOptionsInput";

        public static RemoveOptionsInput FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Tools.Ozone.Setting.RemoveOptionsInput>(json, (JsonTypeInfo<FishyFlip.Lexicon.Tools.Ozone.Setting.RemoveOptionsInput>)SourceGenerationContext.Default.ToolsOzoneSettingRemoveOptionsInput)!;
        }
    }
}

