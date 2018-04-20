using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public enum questType{Knowledge,Comfort,Reputation,Serenity,Protection,Conquest,Wealth,Ability,Equipment};
    enum WealthStrategyType {Gatherrawmaterials, Stealvaluablesforresale, Makevaluablesforresale};

        abstract public class ISimpleQuest
        {
            abstract public void generateStrategy();
        }

        abstract public class SimpleQuest:ISimpleQuest{
            protected questType type;
            protected static Random rnd1=null;
            protected int amount_of_strategies;
            protected List<Strategy> strategies;


            public SimpleQuest()
            {
                if (rnd1 == null)
                    throw new Exception("Quest not initialized. Use SimpleQuest.Init() first.");
                amount_of_strategies = rnd1.Next(1, 5);
                strategies = new List<Strategy>();
            }

            public static void Init(Random r)
            {
                rnd1 = r;
                Action.Init(rnd1);
            }

            public void Generate()
            {
                for (int i = 0; i < amount_of_strategies; i++)
                {
                    generateStrategy();
                }
            }

            questType GenerateRandomQuestType()
            {
                Array values = Enum.GetValues(typeof(questType));
                return (questType)values.GetValue(rnd1.Next(values.Length));
            }

            public void ChangeRandom(Random r)
            {
                Init(r);
            }

            public void changeAmountOfStrategies(int new_value)
            {
                if (new_value <= 0)
                {
                    throw new Exception("changeAmountOfStrategies<=0, should be >=1");
                }
                this.amount_of_strategies = new_value;
                strategies = new List<Strategy>();
            }

            public void changeQuestType(questType q)
            {
                this.type = q;
            }

            public void Write()
            {
                Console.WriteLine("Quest:\nType:{0}",type);
                for (int i = 0; i < amount_of_strategies; i++)
                    strategies[i].Write(2);
            }

        };
    
}
