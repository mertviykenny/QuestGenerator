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
        protected List<Action> subActions=new List<Action>();
        override public void DisplaySingleAction(int indent)
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
                    a.DisplaySingleAction(indent);
                });
        }


        protected string generateNPC()
        {
            string[] prefixes = { "Elder", "Magician", "Warrior", "Ancient", "Brilliant", "Seeker", "Timeless", "Unbound", "Friendly", "Betrayed" };
            string[] names = { "Bond", "Mankrik", "Meto", "Merayl", "Perculia", "Alyssia", "Chargla", "Dalron", "Daakara", "Kilnara" };
            string[] suffixes = { "of the Sun", "of the Moon", "bloody", "the traitor", "the Warrior", "of Odyn", "the Mage", "the fierce", "of the Forest", "the Awesome" };
            return generateName(prefixes, names, suffixes);
        }

        protected string generateObject()
        {
            string[] prefixes = { "Magic", "Lost in time", "Stolen", "Sparkling", "Glooming", "Important", "Poisonous", "Powerfull", "Lost", "Mighty" };
            string[] names = { "Stone", "Book", "Tome", "Diamond", "Note", "Sword", "Dagger", "Message", "Trap", "Spear" };
            string[] suffixes = { "of the Snake", "of the Wolf", "of the Dead", "of arcane magic", "from the Master", "from the One", "of the Invoker", "of the Bandit", "from the Friend", "from the Enemy" };
            return generateName(prefixes, names, suffixes);
        }

        protected string generateName(string[] prefixes, string[] names, string[] suffixes)
        {
            int action = rnd1.Next(0, 10);
            if (action < 2)
            {
                return names[rnd1.Next(0, names.Count())];
            }
            else
            {
                if (action < 5)
                {
                    return prefixes[rnd1.Next(0, prefixes.Count())] + " " + names[rnd1.Next(0, names.Count())];
                }
                else
                {
                    if (action < 8)
                    {
                        return names[rnd1.Next(0, names.Count())] + " " + suffixes[rnd1.Next(0, suffixes.Count())];
                    }
                    else
                    {
                        return prefixes[rnd1.Next(0, prefixes.Count())] + " " + names[rnd1.Next(0, names.Count())] + " " + suffixes[rnd1.Next(0, suffixes.Count())];
                    }
                }
            }
        }


    };
}
