using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public abstract class IAction
    {

        abstract public void DisplaySingleAction(int indent);
    }
    public abstract class Action:IAction
    {
        protected static Random rnd1;
        protected string name;
        protected Object obj;
        protected List<Action> subActions=new List<Action>();
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            if(obj==null)
                Console.WriteLine("{0}",this.name);
            else
                Console.WriteLine("{0}++{1}", this.name,this.obj.getName());
            writeSubActions(indent);
        }
        public static void Init(Random rnd_ref)
        {
            rnd1 = rnd_ref;
        }
        public void DrawIndent(int indent)
        {
            for (int i = 0; i < indent; i++)
            {
                Console.Write(" ");
            }
        }
        public void DrawIndentWithDashes(int indent)
        {
            for (int i = 0; i < indent; i++)
            {
                Console.Write("-");
            }
        }
        protected void writeSubActions(int indent)
        {
            indent = indent + 2;
            if (this.subActions.Count != 0)
                this.subActions.ForEach(delegate (Action a)
                {
                    a.DisplaySingleAction(indent);
                });
        }

    };
}
