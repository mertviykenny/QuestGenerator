using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuestGenerator
{

    class WealthQuests : SimpleQuest
    {
        public WealthQuests()
        {
            this.type = questType.Wealth;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);//45% Wealth_GatherRawMaterials,45% Wealth_StealValuablesForResale, 10% Wealth_MakeValuablesForResale
            if (current_strategy < 45)
                strategies.Add(new Wealth_GatherRawMaterials());
            else
            if (current_strategy >= 45 && current_strategy < 90)
                strategies.Add(new Wealth_StealValuablesForResale());
            else
                strategies.Add(new Wealth_MakeValuablesForResale());
        }
    }
}
