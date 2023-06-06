using CrackingCoding.Chapters.Helpers;

namespace CrackingCoding.Chapters.OOD
{
    public enum SUITE
    {
        HEART,
        CLUB,
        DIAMOND,
        SPADE
    }


    public class Card
    {
        int value;
        SUITE suite;

        public Card(int value, SUITE suite)
        {
            this.value = value;
            this.suite = suite;
        }

        public int getValue() { return this.value; }
        public SUITE GetSUITE() { return this.suite; }
    }

    public class DeckOfCard
    {
        List<Card> deck;

        public DeckOfCard()
        {

            deck = new List<Card>();
            for (int i = 1; i <= 13; i++)
            {
                foreach (SUITE suite in Enum.GetValues(typeof(SUITE)))
                {
                    deck.Add(new Card(i, suite));
                }

            }
        }

        public List<Card> GetDeck() { return deck; }

        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                int firstCard = rand.Next(52);
                int secondCard = rand.Next(52);
                Helper.Swap(deck, firstCard, secondCard);
            }
        }

        public Card dealCard()
        {
            Card removedCard = deck.First();
            deck.Remove(removedCard);
            return removedCard;
        }
    }


    public class Player
    {
        List<Card> hand;

        public Player()
        {
            this.hand = new List<Card>();
        }

        public void addCardToHand(Card card)
        {
            hand.Add(card);
        }

        public int score()
        {
            int sum = 0;
            foreach (Card card in hand)
            {
                sum += card.getValue();
            }
            return sum;
        }
    }
}
