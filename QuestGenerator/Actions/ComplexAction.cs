using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public class Get : Action
    {
        public Get()
        {
            this.name = "Get";
            this.obj = new Item();
            generateStartingAction();
        }

        public Get(Object item_to_get)
        {
            this.name = "Get";
            this.obj = item_to_get;
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
                    subActions.Add(new Steal(obj));
                }
                else
                {
                    if (current_action == 2)
                    {
                        subActions.Add(new GoTo(obj));
                        subActions.Add(new Gather(obj));
                    }
                    else
                    {
                        subActions.Add(new GoTo(obj));
                        subActions.Add(new Get(obj));
                        NPC npc = new NPC();
                        subActions.Add(new GoTo(npc));
                        if (SimpleQuest.GetSubquestGeneration())
                        {
                            subQuest sq = new subQuest();
                            sq.quest.InitializeStartingStrategies();
                            sq.quest.InitializeObjects();
                            subActions.Add(sq);
                        }
                        subActions.Add(new Exchange(obj, npc));
                    }
                }
            }
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, obj.getName());
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
            quest.InitializeStartingStrategies();
            quest.ChangeIndent(indent);
            quest.DisplayQuest();
            DrawIndentWithDashes(indent);
            Console.WriteLine("{0} end", this.name);
        }
    }

    public class Learn : Action
    {
        public Learn()
        {
            this.name = "Learn information about";
            generateStartingAction();
        }

        public Learn(Object o)
        {
            this.name = "Learn information about";
            this.obj = o;
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
                    NPC npc = new NPC();
                    this.subActions.Add(new GoTo(npc));
                    this.subActions.Add(new Listen(npc));
                    if(SimpleQuest.GetSubquestGeneration())
                    {
                        subQuest sq = new subQuest();
                        sq.quest.InitializeStartingStrategies();
                        sq.quest.InitializeObjects();
                        subActions.Add(sq);
                    }
                    this.subActions.Add(new Listen(npc));
                }
                else
                {
                    if (next_action == 2)
                    {
                        Item i = new Item();
                        this.subActions.Add(new GoTo(i));
                        this.subActions.Add(new Get(i));
                        this.subActions.Add(new Read(i));
                    }
                    else
                    {
                        if (obj == null)
                        {
                            Item obj = new Item();
                        }
                        NPC npc = new NPC();
                        this.subActions.Add(new Get(obj));
                        if (SimpleQuest.GetSubquestGeneration())
                        {
                            subQuest sq = new subQuest();
                            sq.quest.InitializeStartingStrategies();
                            sq.quest.InitializeObjects();
                            subActions.Add(sq);
                        }
                        this.subActions.Add(new Give(obj));
                        this.subActions.Add(new Listen(npc));
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

        public GoTo(Object o)
        {
            this.name = "GoTo";
            this.obj = o;
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
                    this.subActions.Add(new Learn(obj));
                else
                    this.subActions.Add(new Explore(obj));
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
            Console.WriteLine("{0} {1}:{2}", this.name, this.x, this.y);
            writeSubActions(indent);
        }
    };


    public class Steal : Action
    {
        public Steal()
        {
            this.name = "Steal";
            this.obj = new Item();
            generateStartingAction();
        }
        public Steal(Object obj)
        {
            this.name = "Steal";
            this.obj = obj;
            generateStartingAction();
        }

        void generateStartingAction()
        {
            int current_action = rnd1.Next();
            if (current_action == 0)
            {
                subActions.Add(new GoTo(obj));
                subActions.Add(new Stealth());
                subActions.Add(new Take(obj));
            }
            else
            {
                NPC npc = new NPC();
                npc.setCoords(obj);
                subActions.Add(new GoTo(npc));
                subActions.Add(new Kill(npc));
                subActions.Add(new Take(obj));
            }
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, obj.getName());
            writeSubActions(indent);
        }
    };
}
