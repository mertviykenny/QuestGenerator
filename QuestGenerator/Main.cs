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
                SimpleQuest.Init(new Random(2));

                KnowledgeQuest q = new KnowledgeQuest();
                q.changeAmountOfStrategies(5);

                //WealthQuests q = new WealthQuests();
                q.Generate();
                q.DisplayQuest();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.GetBaseException());
            }
        }
    }
}
