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
        protected questGenerator.SimpleQuest subQuest;
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
            if (this.subActions.Count != 0 || this.subQuest != null)
                this.subActions.ForEach(delegate (Action a)
                {
                    a.Write(indent);
                });
        }
    };

    public class Repair : Action {
        public Repair()
        {
            this.name = "Repair";
        }
    };

    public class Get : Action
    {
        public Get()
        {
            this.name = "Get";
        }
    };
    public class Nothing : Action//e
    {
        public Nothing()
        {
            this.name = "Nothing";
        }
    }

    public class Listen : Action
    {
        public Listen()
        {
            this.name = "Listen";
        }
    }

    public class subQuest : Action
    {
        QuestGenerator.questGenerator.SimpleQuest quest;
        public  subQuest()
        {
            this.name="subQuest";
            quest = new questGenerator.SimpleQuest(rnd1.Next());
        }
        override public void Write(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} start", this.name);
            writeSubActions(indent);
            quest.Write();
            Console.WriteLine("{0} end", this.name);
        }
    }
    public class Read : Action
    {
        public  Read()
        {
            this.name = "Read";
        }
    }

    public class Give : Action
    {
        public  Give()
        {
            this.name = "Give";
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
    public class Explore : Action
    {
        public Explore()
        {
            this.name = "Explore";
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
        }
    };
}
