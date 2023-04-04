using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace MyApp // Note: actual namespace depends on the project name.
{

//    Question:
//English to Pig Latin Translator



//Pig latin has two very simple rules:

//If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel, to the end of the word and add "ay" to the end.
//have ➞ avehay
//cram ➞ amcray
//take ➞ aketay
//cat ➞ atcay
//shrimp ➞ impshray
//trebuchet ➞ ebuchettray
//If a word starts with a vowel add "yay" to the end of the word.
//ate ➞ ateyay
//apple ➞ appleyay
//oaken ➞ oakenyay
//eagle ➞ eagleyay
//Write two functions to make an English to pig latin translator. The first function TranslateWord(word) takes a single word and returns that word translated into pig latin.The second function TranslateSentence(sentence) takes an English sentence and returns that sentence translated into pig latin.

//Examples
//TranslateWord("flag") ➞ "agflay"

//TranslateWord("Apple") ➞ "Appleyay"

//TranslateWord("button") ➞ "uttonbay"

//TranslateWord("") ➞ ""

//TranslateSentence("I like to eat honey waffles.") ➞ "Iyay ikelay otay eatyay oneyhay afflesway."
    internal class Program
    {
        static string translateSentence(string input) {
            string[] splitWords = input.Split(" ");
            string result = "";
            foreach (string word in splitWords)
            {

                result += translateWord(word) + " ";

            }
            return result;
        }


        static string translateWord(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            // Empty string edgecase
            if (s == "") return "";

            // Check if the last character is a punctuation
            bool hasPunctuation = Char.IsPunctuation(s[s.Length - 1]);
            string punctuation = "";

            // If the word has punctuation, we extract it
            if (hasPunctuation)
            {
                punctuation = s[s.Length - 1].ToString();
                s = s.Substring(0, s.Length - 1);
            }

            // Vowel starting
            if (vowels.Contains(s[0]))
            {
                char[] temp = new char[s.Length + 3];
                temp = s.ToCharArray();
                return (string.Join("", temp)) + "yay" + punctuation;
            }

            // Consonant starting
            else
            {
                int indexOfFirstVowel = 0;
                for (indexOfFirstVowel = 0; indexOfFirstVowel < s.Length; indexOfFirstVowel++)
                {
                    if (vowels.Contains(s[indexOfFirstVowel])) break;
                }
                return s.Substring(indexOfFirstVowel) + s.Substring(0, indexOfFirstVowel) + "ay" + punctuation;
            }
        }
        static void Main(string[] args)
        {
           string test1 = "Hello world! this is Anna";
           string test2 = "I like to eat honey, icecream, waffles and nutella.";
           Console.WriteLine(translateSentence(test1));
           Console.WriteLine(translateSentence(test2));
        }
    }
}