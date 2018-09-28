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

                SimpleQuest.Init(new Random(122412));
                SimpleQuest.SetSubquestGeneration(true);

                WealthQuest q = new WealthQuest();
                q.changeAmountOfStartingActions(4);
                q.InitializeStartingStrategies();
                q.InitializeObjects();
                q.DisplayQuest();
                q.PrintAllObjects();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.GetBaseException());
            }
        }
    }
}
