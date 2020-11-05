using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib;

namespace CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for(int i = 0; i <= 51;i++)
            {
                Card tmpCard = myDeck.GetCard(i);
                Console.WriteLine(tmpCard.ToString()+"\n");

            }
            Console.ReadKey();
        }

    }
}
