using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{

    abstract public class IObject
    {
        protected static Random rnd1;
        public static void Init(Random random)
        {
            rnd1 = random;
        }

        public abstract string getName();
        
    }
    public abstract class Object:IObject
    {
        protected string name;
        protected int x;
        protected int y;
        public Object()
        {
            this.x = rnd1.Next(0, 100);
            this.y = rnd1.Next(0, 100);
            this.name = "ObjName";
        }
        public Object(string name)
        {
            this.name = name;
            generatePosition();
        }

        void generatePosition()
        {
            this.x = rnd1.Next(0, 100);
            this.y = rnd1.Next(0, 100);
        }
        override public string getName()
        {
            return this.name;
        }
        public void setCoords(int new_x, int new_y)
        {
            this.x = new_x;
            this.y = new_y;
        }
        public void setCoords(Object o)
        {
            this.x = o.x;
            this.y = o.y;
        }
        protected string generateName(List<string> prefixes, List<string> names, List<string> suffixes)
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
        protected string generateFragments(string name)
        {
            List<string> prefixes = new List<string>
            {
                "Parts of",
                "Fragments of",
                "Shards of",
                "Elements of"
            };
            return (prefixes[rnd1.Next(0, prefixes.Count)] + " " + name);
        }
    }




    public class NPC : Object
    {
        public NPC()
        {
            generateNPC();
            this.x = rnd1.Next(0, 100);
            this.y = rnd1.Next(0, 100);
        }

        protected void generateNPC()
        {
            List<string> prefixes = new List<string> { "Elder", "Magician", "Warrior", "Ancient", "Brilliant", "Seeker", "Timeless", "Unbound", "Friendly", "Betrayed" };
            List<string> names = new List<string> { "Bond", "Mankrik", "Meto", "Merayl", "Perculia", "Alyssia", "Chargla", "Dalron", "Daakara", "Kilnara" };
            List<string> suffixes = new List<string> { "of the Sun", "of the Moon", "bloody", "the traitor", "the Warrior", "of Odyn", "the Mage", "the fierce", "of the Forest", "the Awesome" };
            this.name = generateName(prefixes, names, suffixes);
        }
    }

    public class Wall : Object
    {

    }

    public class Item : Object
    {

        public Item()
        {
            generateItem();
            this.x = rnd1.Next(0, 100);
            this.y = rnd1.Next(0, 100);
        }
        protected void generateItem()
        {
            List<string> prefixes = new List<string> { "Magic", "Lost in time", "Stolen", "Sparkling", "Glooming", "Important", "Poisonous", "Powerfull", "Lost", "Mighty" };
            List<string> names = new List<string> { "Inscripted Stone", "Book", "Tome", "Diamond", "Note", "Sword", "Dagger", "Message", "Trap", "Spear" };
            List<string> suffixes = new List<string> { "of the Snake", "of the Wolf", "of the Dead", "of arcane magic", "from the Master", "from the One", "of the Invoker", "of the Bandit", "from the Friend", "from the Enemy" };
            this.name = generateName(prefixes, names, suffixes);
        }
    }
}
