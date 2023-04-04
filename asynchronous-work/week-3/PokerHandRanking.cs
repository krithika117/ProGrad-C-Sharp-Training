
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pokers
{
    public static void PokerHandRanking(string[] cards)
    {
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = cards[i].Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14");
        }

        string[] ranks = new string[cards.Length];
        string[] suits = new string[cards.Length];
        int idx = 0;

        foreach (var card in cards)
        {
            ranks[idx] = string.Join("", card.Substring(0, card.Length - 1));
            suits[idx] = string.Join("", card[card.Length - 1]);
            idx = idx + 1;
        }

        Array.Sort(ranks);
        Array.Sort(suits);

        bool isFlush = (suits.Distinct().Count() == 1) ? true : false;
        bool isStraight = (ranks.Distinct().Count() == 5) && ((int.Parse(ranks[4]) - int.Parse(ranks[0])) == 4);

        // Royal Flush
        if (isFlush && isStraight && ranks[0] == "10")
            Console.WriteLine("Royal Flush");

        // Straight Flush
        else if (isFlush && isStraight)
            Console.WriteLine("Straight Flush");

        // Four of a Kind
        else if (ranks.Count(x => x == ranks[2]) == 4)
            Console.WriteLine("Four of a Kind");

        // Full house.1
        else if ((ranks.Count(x => x == ranks[1]) == 2) && (ranks.Count(x => x == ranks[3]) == 3))
            Console.WriteLine("Full house");

        // Full house.2
        else if ((ranks.Count(x => x == ranks[3]) == 2) && (ranks.Count(x => x == ranks[1]) == 3))
            Console.WriteLine("Full house");

        // Straight
        else if (isStraight)
            Console.WriteLine("Straight");

        // Flush
        else if (isFlush)
            Console.WriteLine("Flush");

        // Three of a Kind
        else if (ranks.Count(x => x == ranks[2]) == 3)
            Console.WriteLine("Three of a Kind");

        // Two Pair
        else if ((ranks.Count(x => x == ranks[1]) == 2) && (ranks.Count(x => x == ranks[3]) == 2))
            Console.WriteLine("Two Pair");

        // Pair
        else if ((ranks.Count(x => x == ranks[1]) == 2) || (ranks.Count(x => x == ranks[3]) == 2))
            Console.WriteLine("One Pair");

        // High Card
        else
            Console.WriteLine("High Card");
    }

    public static void RunTests()
    {
        string[] hand1 = { "10C", "JC", "QC", "KC", "AC" }; // Royal Flush
        string[] hand2 = { "2H", "3H", "4H", "5H", "6H" }; // Straight Flush
        string[] hand3 = { "AH", "AD", "AS", "AC", "KD" }; // Four of a Kind
        string[] hand4 = { "2C", "3C", "5C", "8C", "9C" }; // Flush
        string[] hand5 = { "10C", "JC", "QH", "KS", "AH" }; // Straight
        string[] hand6 = { "2H", "2C", "4D", "4C", "4S" }; // Full House
        string[] hand7 = { "2C", "2S", "KH", "KC", "5D" }; // Two Pair
        string[] hand8 = { "10C", "10H", "AC", "KS", "8D" }; // One Pair
        string[] hand9 = { "2C", "3D", "4S", "5H", "7C" }; // High Card
        string[] hand10 = { "AH", "JD", "2S", "2D", "2C" }; // Three of a Kind

        PokerHandRanking(hand1);
        PokerHandRanking(hand2);
        PokerHandRanking(hand3);
        PokerHandRanking(hand4);
        PokerHandRanking(hand5);
        PokerHandRanking(hand6);
        PokerHandRanking(hand7);
        PokerHandRanking(hand8);
        PokerHandRanking(hand9);
        PokerHandRanking(hand10);
    }
    public static void Main(String[] args)
    {
        RunTests();
    }
}

//// [9, 10, 11, 12, 13] => 9+2 = 11 = 13-2
