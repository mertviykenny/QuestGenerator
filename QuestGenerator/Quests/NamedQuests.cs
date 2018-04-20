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
                startingActions.Add(new Wealth_GatherRawMaterials());
            else
            if (current_strategy >= 45 && current_strategy < 90)
                startingActions.Add(new Wealth_StealValuablesForResale());
            else
                startingActions.Add(new Wealth_MakeValuablesForResale());
        }
    }


    class KnowledgeQuest : SimpleQuest
    {
        public KnowledgeQuest()
        {
            this.type = questType.Knowledge;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
            if (current_strategy < 30)
                startingActions.Add(new Knowledge_DeliverItemForStudy());
            else
            if (current_strategy >= 30 && current_strategy < 60)
                startingActions.Add(new Knowledge_InterviewNPC());
            else
                if (current_strategy >= 60 && current_strategy < 90)
                startingActions.Add(new Knowledge_UseItemInTheField());
            else
                startingActions.Add(new Knowledge_Spy());
        }
    }



    class ComfortQuest : SimpleQuest
    {
        public ComfortQuest()
        {
            this.type = questType.Comfort;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
            if (current_strategy < 50)
                startingActions.Add(new Comfort_KillPests());
            else
                startingActions.Add(new Comfort_ObtainLuxuries());

        }
    }


    class ReputationQuest : SimpleQuest
    {
        public ReputationQuest()
        {
            this.type = questType.Reputation;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
            if (current_strategy < 40)
                startingActions.Add(new Reputation_KillEnenmies());
            else
                if(current_strategy>=40 && current_strategy<70)
                    startingActions.Add(new Reputation_ObtainRareItems());
                else
                    startingActions.Add(new Reputation_VisitDangerousPlace());


        }
    }



}
