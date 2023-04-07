using System.Collections.Immutable;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void NicoCipher(string message, string key) {

            char[] temp = key.ToCharArray();
            Array.Sort(temp);
            int noOfSpaces = (message.Length % key.Length == 0) ? message.Length % key.Length : (key.Length - (message.Length % key.Length));
            int noOfRows = (message.Length % key.Length == 0) ? message.Length / key.Length : ((message.Length + noOfSpaces)/key.Length);
            // 15%5 == 0?  messlen/keylen : messLen+noOfSpaces / keylen 

            //Console.WriteLine(noOfRows);
            string sortedKey = new string(temp);
            //Console.WriteLine(sortedKey);
            //Console.WriteLine(key);
            int[] indices = new int[sortedKey.Length];
            int i = 0;
            Dictionary<int, char[]> storeValues = new Dictionary<int, char[]>();

            foreach (char c in key)
            {
                indices[i++] = sortedKey.IndexOf(c)+ 1;
                storeValues[sortedKey.IndexOf(c) + 1] = new char[noOfRows];
            }
            //Console.WriteLine(string.Join(" ", indices));

            char[] messageArray = message.ToCharArray();

            for(int q = 0; q<noOfSpaces; q++)
            {
                message += '$';
            }

            int j = 0;
            for (int idx = 0; idx < noOfRows; idx++) {
                foreach (var kvp in storeValues)
                {

                    kvp.Value[idx] = message[j++];
                    //Console.WriteLine(kvp.Key + " " + string.Join(" ", kvp.Value));

                }
            }
            string res = "";
            var sortedDict = storeValues.ToImmutableSortedDictionary();

            for (int idx = 0; idx < noOfRows; idx++)
            {
                foreach (var kvp in sortedDict)
                {

                    res += kvp.Value[idx];

                    //Console.WriteLine(kvp.Key + " " + string.Join(" ", kvp.Value));

                }
            }

            
            Console.WriteLine(res.Replace('$',' '));
        }
        static void Main(string[] args)
        {
            NicoCipher("mubashirhassan", "crazy");
            NicoCipher("edabitisamazing", "matt");
            NicoCipher("iloveher", "612345");
        }
    }
}

/*
 * 
 * 
 message = 7, key  = 6
 2
 
 message= mubas hirha ssan

14%5 = 5-4 = 1 dollar we can add
 "crazy" = 23154
acryz
0 1 2 3 4

Step 2: Assign numbers to the letters of the given message:
2 3 1 5 4
---------
m u b a s
h i r h a
s s a n $

key-int
value-arr[no.ofrows]
val[3]
{
1: [b,r,a]
2: [m,h,s]
3: [u,i,s]
4: [s,a,$]
5: [a,h,n]
}

Step 3: Sort columns as per assigned numbers:
1 2 3 4 5
---------
b m u s a
r h i a h
a s s   n
Step 4: Return encoded message Rows-wise:
eMessage = "bmusarhiahass n"

 */
