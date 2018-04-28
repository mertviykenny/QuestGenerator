using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public abstract class StartingActions
    {
        public abstract void Write(int indent);
        protected string name;
        protected List<Action> actions = new List<Action>();
        protected void DisplayActions(int indent)
        {
            Console.WriteLine("Type:{0}", name);
            actions.ForEach(delegate (Action a)
            {
                a.DisplaySingleAction(indent);
            });
            Console.Write("\n");
        }
    };

    public class Wealth_GatherRawMaterials : StartingActions
    {
        public Wealth_GatherRawMaterials()
        {
            this.name = "GatherRawMaterials";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Get());
            DisplayActions(indent);
        }
    }

    public class Wealth_StealValuablesForResale : StartingActions
    {
        public Wealth_StealValuablesForResale()
        {
            this.name = "StealValuablesForResale";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Steal());
            DisplayActions(indent);
        }
    }
    public class Wealth_MakeValuablesForResale : StartingActions
    {
        public Wealth_MakeValuablesForResale()
        {
            name = "MakeValuablesForResale";
        }
        override public void Write(int indent)
        {
            actions.Add(new Repair());
            DisplayActions(indent);
        }
    }


    public class Knowledge_DeliverItemForStudy : StartingActions
    {
        public Knowledge_DeliverItemForStudy()
        {
            name = "DeliverItemForStudy";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    }



    public class Knowledge_Spy : StartingActions
    {
        public Knowledge_Spy()
        {
            name = "Spy";
        }
        override public void Write(int indent)
        {
            actions.Add(new Spy());
            DisplayActions(indent);
        }
    }



    public class Knowledge_InterviewNPC : StartingActions
    {
        public Knowledge_InterviewNPC()
        {
            name = "InterviewNPC";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Listen());
            actions.Add(new GoTo());
            actions.Add(new Report());
            DisplayActions(indent);

        }
    };
    public class Knowledge_UseItemInTheField : StartingActions
    {
        public Knowledge_UseItemInTheField()
        {
            name = "UseItemInTheField";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Use());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);

        }
    };


    public class Comfort_ObtainLuxuries : StartingActions
    {
        public Comfort_ObtainLuxuries()
        {
            name = "ObtainLuxuries";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    };


    public class Comfort_KillPests : StartingActions
    {
        public Comfort_KillPests()
        {
            name = "KillPests";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Damage());
            actions.Add(new GoTo());
            actions.Add(new Report());
            DisplayActions(indent);
        }
    };


    public class Reputation_ObtainRareItems : StartingActions
    {
        public Reputation_ObtainRareItems()
        {
            name = "ObtainRareItems";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    };



    public class Reputation_KillEnenmies : StartingActions
    {
        public Reputation_KillEnenmies()
        {
            name = "KillEnenmies";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Kill());
            actions.Add(new GoTo());
            actions.Add(new Report());
            DisplayActions(indent);
        }
    };

    public class Reputation_VisitDangerousPlace : StartingActions
    {
        public Reputation_VisitDangerousPlace()
        {
            name = "VisitDangerousPlace";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new GoTo());
            actions.Add(new Report());
            DisplayActions(indent);
        }
    };

    public class Serenity_Revenge : StartingActions
    {
        public Serenity_Revenge()
        {
            name = "Revenge";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Damage());
            DisplayActions(indent);
        }
    }

    public class Serenity_Capture1 : StartingActions
    {
        public Serenity_Capture1()
        {
            name = "Capture1";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Use());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    }

    public class Serenity_Capture2 : StartingActions
    {
        public Serenity_Capture2()
        {
            name = "Capture2";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Use());
            actions.Add(new Capture());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    }


    public class Serenity_CheckOnNPC1 : StartingActions
    {
        public Serenity_CheckOnNPC1()
        {
            name = "CheckOnNPC1";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Listen());
            actions.Add(new GoTo());
            actions.Add(new Report());
            DisplayActions(indent);
        }
    }


    public class Serenity_CheckOnNPC2 : StartingActions
    {
        public Serenity_CheckOnNPC2()
        {
            name = "CheckOnNPC2";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Take());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    }

    public class Serenity_RecoverLost : StartingActions
    {
        public Serenity_RecoverLost()
        {
            name = "RecoverLost";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    }

    public class Serenity_RescueCaptured : StartingActions
    {
        public Serenity_RescueCaptured()
        {
            name = "RescueCaptured";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Damage());
            actions.Add(new Escort());
            actions.Add(new GoTo());
            actions.Add(new Report());
            DisplayActions(indent);
        }
    }


    public class Protection_Attack : StartingActions
    {
        public Protection_Attack()
        {
            name = "Attack";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Damage());
            actions.Add(new GoTo());
            actions.Add(new Report());
            DisplayActions(indent);
        }
    }

    public class Protection_TreatOrRepair1 : StartingActions
    {
        public Protection_TreatOrRepair1()
        {
            name = "TreatOrRepair1";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Use());
            DisplayActions(indent);
        }
    }


    public class Protection_TreatOrRepair2 : StartingActions
    {
        public Protection_TreatOrRepair2()
        {
            name = "TreatOrRepair2";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Repair());
            DisplayActions(indent);
        }
    }

    public class Protection_CreateDiversion1 : StartingActions
    {
        public Protection_CreateDiversion1()
        {
            name = "CreateDiversion1";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Use());
            DisplayActions(indent);
        }
    }

    public class Protection_CreateDiversion2 : StartingActions
    {
        public Protection_CreateDiversion2()
        {
            name = "CreateDiversion2";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Damage());
            DisplayActions(indent);
        }
    }

    public class Protection_AssembleFortification : StartingActions
    {
        public Protection_AssembleFortification()
        {
            name = "AssembleFortification";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Repair());
            DisplayActions(indent);
        }
    }


    public class Protection_Guard : StartingActions
    {
        public Protection_Guard()
        {
            name = "Guard";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Defend());
            DisplayActions(indent);
        }
    }

    public class Conquest_Attack:StartingActions
    {
        public Conquest_Attack()
        {
            name = "Attack";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Damage());
            DisplayActions(indent);
        }
    }

    public class Conquest_Steal: StartingActions
    {
        public Conquest_Steal()
        {
            name = "Steal";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Steal());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    }


    public class Equipment_Assemble:StartingActions
    {
        public Equipment_Assemble()
        {
            name = "Assemble";
        }
        override public void Write(int indent)
        {
            actions.Add(new Repair());
            DisplayActions(indent);
        }
    }


    public class Equipment_Deliver : StartingActions
    {
        public Equipment_Deliver()
        {
            name = "Deliver";
        }
        override public void Write(int indent)
        {
            actions.Add(new Get());
            actions.Add(new GoTo());
            actions.Add(new Give());
            DisplayActions(indent);
        }
    }


    public class Equipment_Steal : StartingActions
    {
        public Equipment_Steal()
        {
            name = "Steal";
        }
        override public void Write(int indent)
        {
            actions.Add(new Steal());
            DisplayActions(indent);
        }
    }

    public class Equipment_Trade : StartingActions
    {
        public Equipment_Trade()
        {
            name = "Trade";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Exchange());
            DisplayActions(indent);
        }
    }








}
