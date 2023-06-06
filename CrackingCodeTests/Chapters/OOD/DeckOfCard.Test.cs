using CrackingCoding.Chapters.OOD;

namespace CrackingCodeTests.Chapters.OOD
{
    [TestClass]
    public class DeckOfCardTests
    {

        [TestMethod]
        public void deckCreationTest()
        {
            DeckOfCard deckOfCard = new DeckOfCard();
            List<Card> cardDeck = deckOfCard.GetDeck();
            Assert.AreEqual(52, cardDeck.Count);
        }
        [TestMethod]
        public void dealCardTest()
        {
            DeckOfCard deckOfCard = new DeckOfCard();


            deckOfCard.dealCard();
            deckOfCard.dealCard();
            List<Card> cardDeck = deckOfCard.GetDeck();

            Assert.AreEqual(50, cardDeck.Count);
        }

        [TestMethod]
        public void playerHandScoreTest()
        {
            Player player = new Player();
            Card card1 = new Card(2, SUITE.CLUB);
            Card card2 = new Card(8, SUITE.CLUB);

            Assert.AreEqual(0, player.score());

            player.addCardToHand(card1);
            player.addCardToHand(card2);

            Assert.AreEqual(10, player.score());
        }

        [TestMethod]
        public void basicGameTest()
        {
            DeckOfCard deckOfCard = new DeckOfCard();
            List<Card> cardDeck = deckOfCard.GetDeck();

            Player player1 = new Player();
            Player player2 = new Player();

            deckOfCard.shuffle();

            Card card1 = deckOfCard.dealCard();
            player1.addCardToHand(card1);
            Card card2 = deckOfCard.dealCard();
            player2.addCardToHand(card2);

            Card card3 = deckOfCard.dealCard();
            player1.addCardToHand(card3);
            Card card4 = deckOfCard.dealCard();
            player2.addCardToHand(card4);

            int expectedPlayer1Score = card1.getValue() + card3.getValue();
            int expectedPlayer2Score = card2.getValue() + card4.getValue();

            Assert.AreEqual(expectedPlayer1Score, player1.score());
            Assert.AreEqual(expectedPlayer2Score, player2.score());
        }


    }
}
