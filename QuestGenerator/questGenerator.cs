using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public enum questType{Knowledge,Comfort,Reputation,Serenity,Protection,Conquest,Wealth,Ability,Equipment};
    enum WealthStrategyType {Gatherrawmaterials, Stealvaluablesforresale, Makevaluablesforresale};

    public class questGenerator
    {
        public class SimpleQuest {
            questType type;
            Random rnd1;
            int amount_of_strategies;
            List<Strategy> strategies;

            questType GenerateRandomQuestType()
            {
                Array values = Enum.GetValues(typeof(questType));
                return (questType)values.GetValue(rnd1.Next(values.Length));
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

            public SimpleQuest(int seed)
            {
                this.rnd1 = new Random(seed);
                Action.Init(rnd1);
                this.type = GenerateRandomQuestType();
                amount_of_strategies = rnd1.Next(1, 5);
                strategies = new List<Strategy>();
            }

            public void changeQuestType(questType q)
            {
                this.type = q;
            }
            public void Generate()
            {
                if (this.type == questType.Wealth)
                {
                    generateWealthQuest();
                }

            }
            void generateWealthStrategy()
            {
                int current_strategy = rnd1.Next(0,100);//45% Wealth_GatherRawMaterials,45% Wealth_StealValuablesForResale, 10% Wealth_MakeValuablesForResale
                if (current_strategy <45)
                    strategies.Add(new Wealth_GatherRawMaterials());
                else
                if (current_strategy >=45 && current_strategy < 90)
                    strategies.Add(new Wealth_StealValuablesForResale());
                else
                    strategies.Add(new Wealth_MakeValuablesForResale());
            }
            void generateWealthQuest()
            {
                for (int i = 0; i < amount_of_strategies; i++)
                {
                    generateWealthStrategy();
                }
            }


            public void Write()
            {
                Console.WriteLine("Quest:\nType:{0}",type);
                for (int i = 0; i < amount_of_strategies; i++)
                    strategies[i].Write(2);
            }

        };
        static void Main(string[] args)
        {
            try
            {
                SimpleQuest s = new SimpleQuest(12367);
                s.changeQuestType(questType.Wealth);
                s.changeAmountOfStrategies(4);
                s.Generate();
                s.Write();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.GetBaseException());
            }
        }
    }
}
