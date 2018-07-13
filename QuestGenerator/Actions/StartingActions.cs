using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public abstract class StartingActions
    {
        public void Write(int indent) {
            DisplayActions(indent);
        }


        public abstract void GenerateActions();
        protected string name;
        protected List<Action> actions = new List<Action>();

        protected void DisplayActions(int indent)
        {
            Console.WriteLine("Type:{0}", name);
            actions.ForEach(delegate (Action a)
            {
                a.DisplaySingleAction(indent);
            });
        }
    };

    public class Wealth_GatherRawMaterials : StartingActions
    {
        public Wealth_GatherRawMaterials()
        {
            this.name = "GatherRawMaterials";
        }

        override public void GenerateActions()
        {
            Item i = new Item();
            actions.Add(new GoTo(i));
            actions.Add(new Get(i));
        }
    }

    public class Wealth_StealValuablesForResale : StartingActions
    {
        public Wealth_StealValuablesForResale()
        {
            this.name = "StealValuablesForResale";
        }
        override public void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            actions.Add(new GoTo(i));
            actions.Add(new Steal(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Exchange(i, npc));
        }
    }
    public class Wealth_MakeValuablesForResale : StartingActions
    {
        public Wealth_MakeValuablesForResale()
        {
            name = "MakeValuablesForResale";
        }

        public override void GenerateActions()
        {
            actions.Add(new Repair());
        }
    }


    public class Knowledge_DeliverItemForStudy : StartingActions
    {
        public Knowledge_DeliverItemForStudy()
        {
            name = "DeliverItemForStudy";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Give(i));
        }
    }



    public class Knowledge_Spy : StartingActions
    {
        public Knowledge_Spy()
        {
            name = "Spy";
        }
        public override void GenerateActions()
        {
            actions.Add(new Spy());
        }
    }



    public class Knowledge_InterviewNPC : StartingActions
    {
        public Knowledge_InterviewNPC()
        {
            name = "InterviewNPC";
        }

        public override void GenerateActions()
        {
            NPC npc1 = new NPC();
            NPC npc2 = new NPC();
            actions.Add(new GoTo(npc1));
            actions.Add(new Listen(npc1));
            actions.Add(new GoTo(npc2));
            actions.Add(new Report(npc2));
        }
    };
    public class Knowledge_UseItemInTheField : StartingActions
    {
        public Knowledge_UseItemInTheField()
        {
            name = "UseItemInTheField";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            NPC npc2 = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Use(i));
            actions.Add(new GoTo(npc2));
            actions.Add(new Give(i));
        }
    };


    public class Comfort_ObtainLuxuries : StartingActions
    {
        public Comfort_ObtainLuxuries()
        {
            name = "ObtainLuxuries";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Give(i));
        }
    };


    public class Comfort_KillPests : StartingActions
    {
        public Comfort_KillPests()
        {
            name = "KillPests";
        }

        public override void GenerateActions()
        {
            NPC npc1 = new NPC();
            NPC npc2 = new NPC();
            actions.Add(new GoTo(npc1));
            actions.Add(new Damage(npc1));
            actions.Add(new GoTo(npc2));
            actions.Add(new Report(npc2));
        }
    };


    public class Reputation_ObtainRareItems : StartingActions
    {
        public Reputation_ObtainRareItems()
        {
            name = "ObtainRareItems";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Give(npc));
        }
    };



    public class Reputation_KillEnenmies : StartingActions
    {
        public Reputation_KillEnenmies()
        {
            name = "KillEnenmies";
        }
        public override void GenerateActions()
        {
            NPC enemy = new NPC();
            NPC friend = new NPC();
            actions.Add(new GoTo(enemy));
            actions.Add(new Kill(enemy));
            actions.Add(new GoTo(friend));
            actions.Add(new Report(friend));
        }
    };

    public class Reputation_VisitDangerousPlace : StartingActions
    {
        public Reputation_VisitDangerousPlace()
        {
            name = "VisitDangerousPlace";
        }

        public override void GenerateActions()
        {
            Item i1 = new Item();
            Item i2 = new Item();
            i1.setName("Place 1");
            i2.setName("Place 2");
            NPC npc = new NPC();
            actions.Add(new GoTo(i1));
            actions.Add(new GoTo(i2));
            actions.Add(new Report(npc));
        }
    };

    public class Serenity_Revenge : StartingActions
    {
        public Serenity_Revenge()
        {
            name = "Revenge";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            actions.Add(new GoTo(npc));
            actions.Add(new Damage(npc));
        }
    }

    public class Serenity_Capture1 : StartingActions
    {
        public Serenity_Capture1()
        {
            name = "Capture1";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC enemy = new NPC();
            NPC friendly = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(enemy));
            actions.Add(new Use(i));
            actions.Add(new GoTo(friendly));
            actions.Add(new Give(enemy));
        }
    }

    public class Serenity_Capture2 : StartingActions
    {
        public Serenity_Capture2()
        {
            name = "Capture2";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC enemy = new NPC();
            NPC friendly = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(enemy));
            actions.Add(new Use(i));
            actions.Add(new Capture(enemy));
            actions.Add(new GoTo(friendly));
            actions.Add(new Give(enemy));
        }
    }


    public class Serenity_CheckOnNPC1 : StartingActions
    {
        public Serenity_CheckOnNPC1()
        {
            name = "CheckOnNPC1";
        }

        public override void GenerateActions()
        {
            NPC npc1 = new NPC();
            NPC npc2 = new NPC();
            actions.Add(new GoTo(npc1));
            actions.Add(new Listen(npc1));
            actions.Add(new GoTo(npc2));
            actions.Add(new Report(npc2));
        }
    }


    public class Serenity_CheckOnNPC2 : StartingActions
    {
        public Serenity_CheckOnNPC2()
        {
            name = "CheckOnNPC2";
        }

        public override void GenerateActions()
        {
            NPC npc1 = new NPC();
            NPC npc2 = new NPC();
            Item i = new Item();
            actions.Add(new GoTo(npc1));
            actions.Add(new Take(i));
            actions.Add(new GoTo(npc2));
            actions.Add(new Give(i));
        }
    }

    public class Serenity_RecoverLost : StartingActions
    {
        public Serenity_RecoverLost()
        {
            name = "RecoverLost";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Give(npc));
        }
    }

    public class Serenity_RescueCaptured : StartingActions
    {
        public Serenity_RescueCaptured()
        {
            name = "RescueCaptured";
        }

        public override void GenerateActions()
        {
            NPC friendly = new NPC();
            NPC friendly2 = new NPC();
            NPC enemy = new NPC();
            actions.Add(new GoTo(friendly));
            actions.Add(new Damage(enemy));
            actions.Add(new Escort(friendly));
            actions.Add(new GoTo(friendly2));
            actions.Add(new Report(friendly2));
        }
    }


    public class Protection_Attack : StartingActions
    {
        public Protection_Attack()
        {
            name = "Attack";
        }

        public override void GenerateActions()
        {
            NPC friendly = new NPC();
            NPC enemy = new NPC();
            actions.Add(new GoTo(enemy));
            actions.Add(new Damage(enemy));
            actions.Add(new GoTo(friendly));
            actions.Add(new Report(friendly));
        }
    }

    public class Protection_TreatOrRepair1 : StartingActions
    {
        public Protection_TreatOrRepair1()
        {
            name = "TreatOrRepair1";
        }

        public override void GenerateActions()
        {
            NPC npc1 = new NPC();
            Item i = new Item();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc1));
            actions.Add(new Use(i));
        }
    }


    public class Protection_TreatOrRepair2 : StartingActions
    {
        public Protection_TreatOrRepair2()
        {
            name = "TreatOrRepair2";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            actions.Add(new GoTo(npc));
            actions.Add(new Repair(npc));
        }
    }

    public class Protection_CreateDiversion1 : StartingActions
    {
        public Protection_CreateDiversion1()
        {
            name = "CreateDiversion1";
        }
        public override void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Use(i));
        }
    }

    public class Protection_CreateDiversion2 : StartingActions
    {
        public Protection_CreateDiversion2()
        {
            name = "CreateDiversion2";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            actions.Add(new GoTo(npc));
            actions.Add(new Damage(npc));
        }
    }

    public class Protection_AssembleFortification : StartingActions
    {
        public Protection_AssembleFortification()
        {
            name = "AssembleFortification";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            actions.Add(new GoTo(npc));
            actions.Add(new Repair(npc));
        }
    }


    public class Protection_Guard : StartingActions
    {
        public Protection_Guard()
        {
            name = "Guard";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            actions.Add(new GoTo(npc));
            actions.Add(new Defend(npc));
        }
    }

    public class Conquest_Attack : StartingActions
    {
        public Conquest_Attack()
        {
            name = "Attack";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            actions.Add(new GoTo(npc));
            actions.Add(new Damage(npc));
        }
    }

    public class Conquest_Steal : StartingActions
    {
        public Conquest_Steal()
        {
            name = "Steal";
        }

        public override void GenerateActions()
        {
            NPC enemy = new NPC();
            Item i = new Item();
            i.setCoords(enemy);
            NPC npc = new NPC();
            actions.Add(new GoTo(enemy));
            actions.Add(new Steal(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Give(i));
        }
    }


    public class Equipment_Assemble : StartingActions
    {
        public Equipment_Assemble()
        {
            name = "Assemble";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            actions.Add(new Repair(npc));
        }
    }


    public class Equipment_Deliver : StartingActions
    {
        public Equipment_Deliver()
        {
            name = "Deliver";
        }

        public override void GenerateActions()
        {
            NPC npc = new NPC();
            Item i = new Item();
            actions.Add(new Get(i));
            actions.Add(new GoTo(npc));
            actions.Add(new Give(i));
        }
    }


    public class Equipment_Steal : StartingActions
    {
        public Equipment_Steal()
        {
            name = "Steal";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            actions.Add(new Steal(i));
        }
    }

    public class Equipment_Trade : StartingActions
    {
        public Equipment_Trade()
        {
            name = "Trade";
        }

        public override void GenerateActions()
        {
            Item i = new Item();
            NPC npc = new NPC();
            actions.Add(new GoTo(npc));
            actions.Add(new Exchange(i, npc));
        }
    }








}
