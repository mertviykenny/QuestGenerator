using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    class main
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleQuest.Init(new Random(123));


                WealthQuests q = new WealthQuests();
                q.Generate();
                q.Write();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.GetBaseException());
            }
        }
    }
}
