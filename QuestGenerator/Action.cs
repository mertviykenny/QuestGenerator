using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public abstract class IAction
    {

        abstract public void Write(int indent);
    }
    public abstract class Action:IAction
    {
        protected static Random rnd1;
        protected string name;
        protected List<Action> subActions=new List<Action>();
        override public void Write(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0}",this.name);
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
        protected void writeSubActions(int indent)
        {
            indent = indent + 2;
            if (this.subActions.Count != 0)
                this.subActions.ForEach(delegate (Action a)
                {
                    a.Write(indent);
                });
        }
    };


    public class Get : Action
    {
        public Get()
        {
            this.name = "Get";
            int current_action = rnd1.Next(0,4);
            if (current_action == 0)
            {
                subActions.Add(new Nothing());
            }
            else
            {
                if (current_action == 1)
                {
                    subActions.Add(new Steal());
                }
                else
                {
                    if (current_action == 2)
                    {
                        subActions.Add(new GoTo());
                        subActions.Add(new Gather());
                    }
                    else
                    {
                        subActions.Add(new GoTo());
                        subActions.Add(new Get());
                        subActions.Add(new GoTo());
                        subActions.Add(new subQuest());
                        subActions.Add(new Exchange());
                    }
                }
            }
        }
    };


    public class subQuest : Action
    {
        SimpleQuest quest;
        public  subQuest()
        {
            this.name="subQuest";
           // quest = new questGenerator.SimpleQuest(rnd1.Next());
        }
        override public void Write(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} start", this.name);
            writeSubActions(indent);
            //  quest.Write();
            DrawIndent(indent);
            Console.WriteLine("{0} end", this.name);
        }
    }

    public class Learn : Action
    {
        public Learn()
        {
            this.name = "Learn";
            int next_action = rnd1.Next(0, 3);
            if (next_action == 0)
            {
                this.subActions.Add(new Nothing());
            }
            else
            {
                if (next_action == 1)
                {
                    this.subActions.Add(new GoTo());
                    this.subActions.Add(new subQuest());
                    this.subActions.Add(new Listen());
                }
                else
                {
                    if (next_action == 2)
                    {
                        this.subActions.Add(new GoTo());
                        this.subActions.Add(new Get());
                        this.subActions.Add(new Read());
                    }
                    else
                    {
                        this.subActions.Add(new Get());
                        this.subActions.Add(new subQuest());
                        this.subActions.Add(new Give());
                        this.subActions.Add(new Listen());
                    }
                }
            }
        }
    }
    public class GoTo : Action
    {
        public GoTo()
        {
            this.name = "GoTo";
            int next_action = rnd1.Next(0, 3);
            if (next_action == 0)
            {
                this.subActions.Add(new Nothing());
            }
            else
            {
                if (next_action == 1)
                    this.subActions.Add(new Learn());
                else
                    this.subActions.Add(new Explore());
            }
        }
    };


    public class Steal : Action
    {
        public Steal()
        {
            this.name = "Steal";
            int current_action = rnd1.Next();
            if (current_action == 0)
            {
                subActions.Add(new GoTo());
                subActions.Add(new Stealth());
                subActions.Add(new Take());
            }
            else
            {
                subActions.Add(new GoTo());
                subActions.Add(new Kill());
                subActions.Add(new Take());
            }
        }
    };
}
