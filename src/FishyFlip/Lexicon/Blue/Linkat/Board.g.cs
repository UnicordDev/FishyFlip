// <auto-generated />
// This file was generated by FFSourceGen.
// Do not modify this file.

#nullable enable annotations
#nullable disable warnings

namespace FishyFlip.Lexicon.Blue.Linkat
{
    /// <summary>
    /// Record containing a cards of your profile.
    /// </summary>
    public partial class Board : ATObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="cards">List of cards in the board.</param>
        public Board(List<FishyFlip.Lexicon.Blue.Linkat.Card>? cards)
        {
            this.Cards = cards;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        public Board()
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        public Board(CBORObject obj)
        {
            if (obj["cards"] is not null) this.Cards = obj["cards"].Values.Select(n =>new FishyFlip.Lexicon.Blue.Linkat.Card(n)).ToList();
        }

        /// <summary>
        /// Gets or sets the cards.
        /// <br/> List of cards in the board.
        /// </summary>
        [JsonPropertyName("cards")]
        public List<FishyFlip.Lexicon.Blue.Linkat.Card>? Cards { get; set; }

        /// <summary>
        /// Gets the ATRecord Type.
        /// </summary>
        [JsonPropertyName("$type")]
        public override string Type => "blue.linkat.board";

        public const string RecordType = "blue.linkat.board";

        public override string ToJson()
        {
            return JsonSerializer.Serialize<FishyFlip.Lexicon.Blue.Linkat.Board>(this, (JsonTypeInfo<FishyFlip.Lexicon.Blue.Linkat.Board>)SourceGenerationContext.Default.BlueLinkatBoard)!;
        }

        public static Board FromJson(string json)
        {
            return JsonSerializer.Deserialize<FishyFlip.Lexicon.Blue.Linkat.Board>(json, (JsonTypeInfo<FishyFlip.Lexicon.Blue.Linkat.Board>)SourceGenerationContext.Default.BlueLinkatBoard)!;
        }
    }
}

