using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public abstract class Strategy
    {
        public abstract void Write(int indent);
        protected string name;
        protected List<Action> actions=new List<Action>();
        protected void WriteAction(int indent)
        {
            Console.WriteLine("\nType:{0}", name);
            actions.ForEach(delegate (Action a)
            {
                a.Write(indent);
            });
        }
    };

    public class Wealth_GatherRawMaterials : Strategy
    {
        public Wealth_GatherRawMaterials()
        {
            this.name = "GatherRawMaterials";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Get());
            WriteAction( indent);
        }
    }

    public class Wealth_StealValuablesForResale : Strategy
    {
        public Wealth_StealValuablesForResale()
        {
            this.name = "StealValuablesForResale";
        }
        override public void Write(int indent)
        {
            actions.Add(new GoTo());
            actions.Add(new Steal());
            WriteAction( indent);
        }
    }
    public class Wealth_MakeValuablesForResale : Strategy
    {
        public Wealth_MakeValuablesForResale()
        {
            name = "MakeValuablesForResale";
        }
        override public void Write(int indent)
        {
            actions.Add(new Repair());
            WriteAction(indent);
        }
    }
}
