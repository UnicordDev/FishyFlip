// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable

namespace FishyFlip.Lexicon.Community.Lexicon.Bookmarks
{
    public partial class GetActorBookmarksOutput : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorBookmarksOutput"/> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="bookmarks"></param>
        public GetActorBookmarksOutput(string? cursor = default, List<Community.Lexicon.Bookmarks.Bookmark>? bookmarks = default)
        {
            this.Cursor = cursor;
            this.Bookmarks = bookmarks;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorBookmarksOutput"/> class.
        /// </summary>
        public GetActorBookmarksOutput()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="GetActorBookmarksOutput"/> class.
        /// </summary>
        public GetActorBookmarksOutput(CBORObject obj)
        {
            if (obj["cursor"] is not null) this.Cursor = obj["cursor"].AsString();
            if (obj["bookmarks"] is not null) this.Bookmarks = obj["bookmarks"].Values.Select(n =>new Community.Lexicon.Bookmarks.Bookmark(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the cursor.
        /// </summary>
        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Gets or sets the bookmarks.
        /// </summary>
        [JsonPropertyName("bookmarks")]
        [JsonRequired]
        public List<Community.Lexicon.Bookmarks.Bookmark>? Bookmarks { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "community.lexicon.bookmarks.getActorBookmarks#GetActorBookmarksOutput";

        public const string RecordType = "community.lexicon.bookmarks.getActorBookmarks#GetActorBookmarksOutput";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<Community.Lexicon.Bookmarks.GetActorBookmarksOutput>(this, (JsonTypeInfo<Community.Lexicon.Bookmarks.GetActorBookmarksOutput>)SourceGenerationContext.Default.CommunityLexiconBookmarksGetActorBookmarksOutput)!;
        }

        public static GetActorBookmarksOutput FromJson(string json)
        {
            return JsonSerializer.Deserialize<Community.Lexicon.Bookmarks.GetActorBookmarksOutput>(json, (JsonTypeInfo<Community.Lexicon.Bookmarks.GetActorBookmarksOutput>)SourceGenerationContext.Default.CommunityLexiconBookmarksGetActorBookmarksOutput)!;
        }
    }
}

