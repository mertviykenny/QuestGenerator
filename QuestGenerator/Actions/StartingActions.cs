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
        protected List<Action> actions=new List<Action>();
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


    public class Knowledge_DeliverItemForStudy: StartingActions
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



    public class Reputation_KillEnenmies: StartingActions
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


}
