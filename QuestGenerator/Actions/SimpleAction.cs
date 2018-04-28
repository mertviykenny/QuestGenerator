using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestGenerator
{
    public class Nothing : Action
    {
        public Nothing()
        {
            this.name = "Nothing";
        }

        override public void DisplaySingleAction(int indent)
        {
            /*
            DrawIndent(indent);
            Console.WriteLine("{0}", this.name);
            writeSubActions(indent);
            */
        }
    }

    public class Kill : Action
    {
        string NPCName;
        public Kill()
        {
            this.name = "Kill";
            this.NPCName = generateNPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name,this.NPCName);
            writeSubActions(indent);
        }
    }; 



    public class Capture : Action
    {
        string NPCName;
        public Capture()
        {
            this.name = "Capture";
            this.NPCName = generateNPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.NPCName);
            writeSubActions(indent);
        }
    }


    public class Damage : Action
    {
        public Damage()
        {
            this.name = "Damage";
        }
    }

    public class Defend : Action
    {
        string NPCName;
        public Defend()
        {
            this.name = "Defend";
            this.NPCName = generateNPC();
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.NPCName);
            writeSubActions(indent);
        }
    }

    public class Escort : Action
    {
        string NPCName;
        public Escort()
        {
            this.name = "Escort";
            this.NPCName = generateNPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.NPCName);
            writeSubActions(indent);
        }
    }


    public class Exchange : Action
    {
        string ObjectName;
        public Exchange()
        {
            this.name = "Exchange";
            this.ObjectName = generateObject();
        }
        public Exchange(string obj)
        {
            this.name = "Exchange";
            this.ObjectName = obj;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.ObjectName);
            writeSubActions(indent);
        }
    }

    public class Explore : Action
    {
        public Explore()
        {
            this.name = "Explore/Check";
        }
    }

    public class Gather : Action
    {
        string ObjectName;
        public Gather()
        {
            this.name = "Gather";
            this.ObjectName = generateGatherable();
        }

        public Gather(string name)
        {
            this.name = "Gather";
            int random_value = rnd1.Next(1, 8);
            this.ObjectName = random_value.ToString()+" "+generateName(name);
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.ObjectName);
            writeSubActions(indent);
        }

    }


    public class Give : Action
    {
        string ObjectName;
        public Give()
        {
            this.name = "Give";
            this.ObjectName = generateObject();
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.ObjectName);
            writeSubActions(indent);
        }
    }

    public class Listen : Action
    {
        string NPCName;
        public Listen()
        {
            this.name = "Listen";
            this.NPCName = generateNPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} to {1}", this.name, this.NPCName);
            writeSubActions(indent);
        }
    }

    public class Read : Action
    {
        public Read()
        {
            this.name = "Read";
        }
    }

    public class Repair : Action
    {
        public Repair()
        {
            this.name = "Repair or create";
        }
    };


    public class Report : Action
    {
        string NPCName;
        public Report()
        {
            this.name = "Report";
            this.NPCName = generateNPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} to {1}", this.name, this.NPCName);
            writeSubActions(indent);
        }
    };

    public class Spy : Action
    {

        string NPCName;
        public Spy()
        {
            this.name = "Spy";
            this.NPCName = generateNPC();
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} on {1}", this.name, this.NPCName);
            writeSubActions(indent);
        }
    };

    public class Stealth : Action
    {
        public Stealth()
        {
            this.name = "Stealth";
        }
    };


    public class Take : Action
    {
        string ObjectName;
        public Take()
        {
            this.name = "Take";
            this.ObjectName = generateObject();
        }
        public Take(string obj)
        {
            this.name = "Take";
            this.ObjectName = obj;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.ObjectName);
            writeSubActions(indent);
        }
    };

    public class Use : Action
    {
        public Use()
        {
            this.name = "Use";
        }
    };
}
