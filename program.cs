using System.Net.Security;
using System.Net.WebSockets;

namespace RandomSentencesGenerator
{
    internal class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve", "Clare", "Jake", "Viktor", "George", "Ron", "Harry", "Ben", "Phoebe", "Albus", "Caren", "Emma",
                "Liam", "Sophia", "Noah", "Ava", "Oliver", "Isabella", "Elijah", "Mia", "James" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas", "London", "Berlin", "Moscow", "Oslo", "Tokyo", "Denver", "Amsterdam", "Smolyan",
                "Barcelona", "Cairo", "Istanbul", "Toronto", "Sydney", "Mumbai", "Oslo", "Buenos Aires", "Seoul" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings", "devides", "carries", "destoroys", "bakes", "falls on", "pushes",
                "writes", "sings", "meets" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes", "mountain", "keyboard", "river", "galaxy", "mirror", "engine", "pencil",
                "cloud", "forest", "rocket" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly", "loudly", "often", "neatly", "barely", "cheerfully", "firmly",
                "gently", "slowly", "truthfully", "rarely", "boldly", "brightly", "cleverly", "deliberately", "foolishly", "grumpily", "honestly", "kindly", "madly", "nervously" };
            string[] details = { "under the bridge", "behind the house", "beside the fireplace", "above the clouds", "near the forest", "in the cave",
                "across the street", "on the rooftop", "through the tunnel", "next to the lake", "beneath the old oak", "along the sandy shore", "inside the ancient ruin",
                "beyond the mountain pass",
                "within the bustling market", "close to the waterfall" };

            Console.WriteLine("Hello this is you first random sentence");
            while (true)
            {
                string randomName = randomWord(names);
                string randomPlace = randomWord(places);
                string randomVerb = randomWord(verbs);
                string randomNouns = randomWord(nouns);
                string randomAdverb = randomWord(adverbs);
                string randomDetails = randomWord(details);


                string who = $"{randomName} from {randomPlace} ";
                string action = $"{randomVerb} {randomNouns} {randomAdverb} {randomDetails}";

                string sentence = $"{who}{action}";

                Console.WriteLine(sentence);
                Console.WriteLine("Click ENTER to get a new one");
                Console.ReadLine();
                Console.WriteLine("This is your new sentence");
            }


        }

        static string randomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length - 1);
            string word = words[randomIndex];
            return word;
        }
    }
}
