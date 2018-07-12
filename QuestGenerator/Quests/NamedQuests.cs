using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuestGenerator
{

    class WealthQuest : SimpleQuest
    {
        public WealthQuest()
        {
            this.type = questType.Wealth;
        }


        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
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
                if (current_strategy >= 40 && current_strategy < 70)
                startingActions.Add(new Reputation_ObtainRareItems());
            else
                startingActions.Add(new Reputation_VisitDangerousPlace());
        }
    }

    class SerenityQuest : SimpleQuest
    {
        public SerenityQuest()
        {
            this.type = questType.Serenity;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
            if (current_strategy < 11)
                startingActions.Add(new Serenity_Revenge());
            else
            {
                if (current_strategy < 28)
                    startingActions.Add(new Serenity_Capture1());
                else
                    if (current_strategy < 35)
                    startingActions.Add(new Serenity_Capture2());
                else
                        if (current_strategy < 45)
                    startingActions.Add(new Serenity_CheckOnNPC1());
                else
                            if (current_strategy < 58)
                    startingActions.Add(new Serenity_CheckOnNPC2());
                else
                                if (current_strategy < 75)
                    startingActions.Add(new Serenity_RecoverLost());
                else
                    startingActions.Add(new Serenity_RescueCaptured());


            }
        }
    }

    class ProtectionQuest : SimpleQuest
    {
        public ProtectionQuest()
        {
            this.type = questType.Protection;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
            if (current_strategy < 11)
                startingActions.Add(new Protection_Attack());
            else
            {
                if (current_strategy < 28)
                    startingActions.Add(new Protection_TreatOrRepair1());
                else
                    if (current_strategy < 35)
                    startingActions.Add(new Protection_TreatOrRepair2());
                else
                        if (current_strategy < 45)
                    startingActions.Add(new Protection_CreateDiversion1());
                else
                            if (current_strategy < 58)
                    startingActions.Add(new Protection_CreateDiversion2());
                else
                                if (current_strategy < 75)
                    startingActions.Add(new Protection_AssembleFortification());
                else
                    startingActions.Add(new Protection_Guard());
            }
        }
    }

    class ConquestQuest : SimpleQuest
    {
        public ConquestQuest()
        {
            this.type = questType.Conquest;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
            if (current_strategy < 50)
                startingActions.Add(new Conquest_Attack());
            else
                startingActions.Add(new Conquest_Steal());

        }
    }

    class EquipmentQuest : SimpleQuest
    {
        public EquipmentQuest()
        {
            this.type = questType.Equipment;
        }

        override public void generateStrategy()
        {
            int current_strategy = rnd1.Next(0, 100);
            if (current_strategy < 25)
                startingActions.Add(new Equipment_Assemble());
            else
                if (current_strategy < 50)
                startingActions.Add(new Equipment_Deliver());
            else
                    if (current_strategy < 75)
                startingActions.Add(new Equipment_Steal());
            else
                startingActions.Add(new Equipment_Trade());


        }
    }




}
