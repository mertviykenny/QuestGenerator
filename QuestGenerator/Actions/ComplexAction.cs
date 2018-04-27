using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public class Get : Action
    {
        string ObjectName;
        public Get()
        {
            this.name = "Get";
            this.ObjectName = generateObject();
            generateStartingAction();
        }

        void generateStartingAction()
        {
            int current_action = rnd1.Next(0, 4);
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

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.ObjectName);
            writeSubActions(indent);
        }
    };


    public class subQuest : Action
    {
        SimpleQuest quest;
        public subQuest()
        {
            this.name = "subQuest";
            // quest = new questGenerator.SimpleQuest(rnd1.Next());
        }
        override public void DisplaySingleAction(int indent)
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
            this.name = "Learn information";
            generateStartingAction();
        }

        void generateStartingAction()
        {
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
        int x;
        int y;
        public GoTo()
        {
            this.name = "GoTo";
            generateStartingAction();
            generateX();
            generateY();
        }

        void generateStartingAction()
        {
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

        void generateX()
        {
            this.x = rnd1.Next(0, 100);
        }
        void generateY()
        {
            this.y = rnd1.Next(0, 100);
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}:{2}", this.name, this.x,this.y);
            writeSubActions(indent);
        }
    };


    public class Steal : Action
    {
        string ObjectName;
        public Steal()
        {
            this.name = "Steal";
            this.ObjectName = generateObject();
            generateStartingAction();
        }

        void generateStartingAction()
        {
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

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.ObjectName);
            writeSubActions(indent);
        }
    };
}
