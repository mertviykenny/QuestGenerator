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
        NPC npc;
        public Kill()
        {
            this.name = "Kill";
            this.npc = new NPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name,this.npc.getName());
            writeSubActions(indent);
        }
    }; 



    public class Capture : Action
    {
        NPC npc;
        public Capture()
        {
            this.name = "Capture";
            this.npc = new NPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.npc.getName());
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
        NPC npc;
        public Defend()
        {
            this.name = "Defend";
            this.npc = new NPC();
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.npc.getName());
            writeSubActions(indent);
        }
    }

    public class Escort : Action
    {
        NPC npc;
        public Escort()
        {
            this.name = "Escort";
            this.npc = new NPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.npc.getName());
            writeSubActions(indent);
        }
    }


    public class Exchange : Action
    {
        Object item;
        public Exchange()
        {
            this.name = "Exchange";
            this.item= new Item();
        }
        public Exchange(Object obj)
        {
            this.name = "Exchange";
            this.item = obj;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.item.getName());
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
        Object obj;
        public Gather()
        {
            this.name = "Gather/PickUp";
            this.obj = new Item();
        }

        public Gather(Object gather)
        {
            this.name = "Gather/PickUp";
            this.obj = gather;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }

    }


    public class Give : Action
    {
        Object obj;
        public Give()
        {
            this.name = "Give";
            this.obj = new Item();
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    }

    public class Listen : Action
    {
        Object npc;
        public Listen()
        {
            this.name = "Listen";
            this.npc =new NPC();
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} to {1}", this.name, this.npc.getName());
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
        Object npc;
        public Report()
        {
            this.name = "Report";
            this.npc = new NPC();
        }
        public Report(Object obj)
        {
            this.npc = obj;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} to {1}", this.name, this.npc.getName());
            writeSubActions(indent);
        }
    };

    public class Spy : Action
    {

        Object npc;
        public Spy()
        {
            this.name = "Spy";
            this.npc = new NPC();
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} on {1}", this.name, this.npc.getName());
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
        Object item;
        public Take()
        {
            this.name = "Take";
            this.item = new Item();
        }
        public Take(Object obj)
        {
            this.name = "Take";
            this.item = obj;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.item.getName());
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
