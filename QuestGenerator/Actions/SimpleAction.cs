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
        public Kill()
        {
            this.name = "Kill";
            this.obj = new NPC();
        }
        public Kill(Object o)
        {
            this.name = "Kill";
            this.obj = o;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    };



    public class Capture : Action
    {
        public Capture()
        {
            this.name = "Capture";
            this.obj = new NPC();
        }
        public Capture(Object o)
        {
            this.name = "Capture";
            this.obj = o;
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    }


    public class Damage : Action
    {
        public Damage()
        {
            this.name = "Damage";
        }

        public Damage(Object o)
        {
            this.name = "Damage";
            this.obj = o;
        }
    }

    public class Defend : Action
    {
        public Defend()
        {
            this.name = "Defend";
            this.obj = new NPC();
        }
        public Defend(Object o)
        {
            this.name = "Defend";
            this.obj = o;
        }
        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    }

    public class Escort : Action
    {
        public Escort()
        {
            this.name = "Escort";
            this.obj = new NPC();
        }

        public Escort(Object o)
        {
            this.name = "Escort";
            this.obj = o;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    }


    public class Exchange : Action
    {
        Object item;
        Object npc;
        public Exchange()
        {
            this.name = "Exchange";
            this.obj = new Item();
        }
        public Exchange(Object new_item, Object new_NPC)
        {
            this.name = "Exchange";
            this.item = new_item;
            this.npc = new_NPC;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1} with {2}", this.name, this.item.getName(), this.npc.getName());
            writeSubActions(indent);
        }
    }

    public class Explore : Action
    {
        public Explore()
        {
            this.name = "Explore/Check/Find about";
        }

        public Explore(Object o)
        {
            this.name = "Explore/Check/Find about";
            this.obj = o;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            if (this.obj != null)
                Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            else
                Console.WriteLine("{0}", this.name);


            writeSubActions(indent);
        }
    }

    public class Gather : Action
    {
        public Gather()
        {
            this.name = "Gather/PickUp";
            this.obj = new Item();
        }

        public Gather(Object o)
        {
            this.name = "Gather/PickUp";
            this.obj = o;
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
        public Give()
        {
            this.name = "Give";
            this.obj = new Item();
        }

        public Give(Object o)
        {
            this.name = "Give";
            this.obj = o;
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
        public Listen()
        {
            this.name = "Listen";
            this.obj = new NPC();
        }

        public Listen(Object o)
        {
            this.name = "Listen";
            this.obj = o;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} to {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    }

    public class Read : Action
    {

        public Read()
        {
            this.name = "Read";
            this.obj = new Item();
        }

        public Read(Object o)
        {
            this.name = "Read";
            this.obj = o;
        }
    }

    public class Repair : Action
    {
        public Repair()
        {
            this.name = "Repair or create";
            this.obj = new NPC();
        }
        public Repair(Object o)
        {
            this.obj = o;
        }
    };


    public class Report : Action
    {
        public Report()
        {
            this.name = "Report";
            this.obj = new NPC();
        }
        public Report(Object o)
        {
            this.name = "Report";
            this.obj = o;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} to {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    };

    public class Spy : Action
    {
        public Spy()
        {
            this.name = "Spy";
            this.obj = new NPC();
        }

        public Spy(Object o)
        {
            this.name = "Spy";
            this.obj = o;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} on {1}", this.name, this.obj.getName());
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
        public Take()
        {
            this.name = "Take";
            this.obj = new Item();
        }
        public Take(Object o)
        {
            this.name = "Take";
            this.obj = o;
        }

        override public void DisplaySingleAction(int indent)
        {
            DrawIndent(indent);
            Console.WriteLine("{0} {1}", this.name, this.obj.getName());
            writeSubActions(indent);
        }
    };

    public class Use : Action
    {
        public Use()
        {
            this.name = "Use";
            this.obj = new Item();
        }
        public Use(Object o)
        {
            this.name = "Use";
            this.obj = o;
        }
    };
}
