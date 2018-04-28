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

        public Get(string item_to_get)
        {
            this.name = "Get";
            this.ObjectName = item_to_get;
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
                    subActions.Add(new Steal(ObjectName));
                }
                else
                {
                    if (current_action == 2)
                    {
                        subActions.Add(new GoTo());
                        subActions.Add(new Gather(this.ObjectName));
                    }
                    else
                    {
                        subActions.Add(new GoTo());
                        subActions.Add(new Get(ObjectName));
                        subActions.Add(new GoTo());
                        subQuest sq = new subQuest();
                        sq.ChangeIndent(15);
                        subActions.Add(sq);
                        subActions.Add(new Exchange(ObjectName));
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
        public SimpleQuest quest;
        int quest_indent = 0;
        public subQuest()
        {
            this.name = "subQuest";
            int action = rnd1.Next(0, Enum.GetNames(typeof(questType)).Length);
            if (action == 0)
                quest = new KnowledgeQuest();
            if (action == 1)
                quest = new ComfortQuest();
            if (action == 2)
                quest = new ReputationQuest();
            if (action == 3)
                quest = new SerenityQuest();
            if (action == 4)
                quest = new ProtectionQuest();
            if (action == 5)
                quest = new ConquestQuest();
            if (action == 6)
                quest = new WealthQuest();
            if (action == 7)
                quest = new EquipmentQuest();
        }
        override public void DisplaySingleAction(int indent)
        {
            indent = indent + quest_indent;
            DrawIndentWithDashes(indent);
            Console.Write("{0} started, ", this.name);
            writeSubActions(indent);
            quest.Generate();
            quest.ChangeIndent(indent);
            quest.DisplayQuest();
            DrawIndentWithDashes(indent);
            Console.WriteLine("{0} end", this.name);
        }
        public void ChangeIndent(int new_value)
        {
            this.quest_indent = new_value;
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
                    subQuest sq = new subQuest();
                    sq.ChangeIndent(2);
                    subActions.Add(sq);
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
                        subQuest sq = new subQuest();
                        sq.ChangeIndent(2);
                        subActions.Add(sq);
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
        public Steal(string obj)
        {
            this.name = "Steal";
            this.ObjectName = obj;
            generateStartingAction();
        }

        void generateStartingAction()
        {
            int current_action = rnd1.Next();
            if (current_action == 0)
            {
                subActions.Add(new GoTo());
                subActions.Add(new Stealth());
                subActions.Add(new Take(ObjectName));
            }
            else
            {
                subActions.Add(new GoTo());
                subActions.Add(new Kill());
                subActions.Add(new Take(ObjectName));
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
