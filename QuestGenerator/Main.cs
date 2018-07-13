using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    
    class main
    {
        public static Boolean canGenerateSubquest = false;
        static void Main(string[] args)
        {
            try
            {
                SimpleQuest.Init(new Random(122412));

                WealthQuest q = new WealthQuest();
                canGenerateSubquest = true;
                q.changeAmountOfStartingActions(4);
                q.InitializeStartingStrategies();
                q.InitializeObjects();
                q.DisplayQuest();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.GetBaseException());
            }
        }
    }
}
