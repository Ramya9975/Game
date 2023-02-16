using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MASTER");
            int score = 0;

            string[] masterList = new string[]
                { "master","eats","term","armets", "maters", "matres", "ramets", "stream", "tamers","armet","aster","mares","marse","marts","maser","mater"
 ,               "mates","meats","ramet","rates","reams","resat","satem","smart","smear","stare","steam","tamer","tames","tares","teams","tears","terms","trams",
                 "ares","arms","arts","ates","ears","east","eats","eras","erst","etas","maes","mare","mars","mart","mast","mate","mats","meat","mesa","meta","rams",
                    "rase","rate","rats","ream","rems","rest","rets","same","sate","seam","sear","seat","sera","seta","star","stem","tame","tams","tare","tars",
                    "team","tear","teas","term","tram","tres","tsar","are","arm","ars","art","ate","ear","eat","ems","era","ers","eta","mae","mar","mas","mat",
                    "met","ram","ras","rat","rem","res","ret","sae","sat","sea","ser","set","tae","tam","tar","tas","tea","ae","am","ar","as","at","em","er",
                      "es","et","ma","me","re","ta" };


         

            


            /*foreach (char ch in userInput.ToUpper())
            {
                char[] strings = new char[] { 'M', 'A', 'S', 'T', 'E', 'R' };
                {

                    if (strings.Contains(ch))

                    {
                        score += 1;

                    }
                    else
                    {
                        score -= 1;
                    }

                }
            }*/
           
            int i = 1;
            List<string> input = new List<string>();
            while (i > 0)
            {

                Console.Write("Enter a new word using characters in MASTER: ");
                string userInput = Console.ReadLine();
                string user = userInput.ToLower();
                if (user != "quit")
                {




                    if (masterList.Contains(user))
                    {
                        Console.WriteLine("You have entered a correct word and u earn a point");
                        score++;
                    }

                    else
                    {
                        Console.WriteLine("INCORRECT - Please Enter a valid input");

                    }

                }
                else
                {
                    i = 0;
                }
            }
           
            Console.WriteLine(score);
            Console.ReadLine();
        }
    }
}




