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
        public Defend()
        {
            this.name = "Defend";
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
        public Exchange()
        {
            this.name = "Exchange";
        }
    }


    public class Experiment : Action
    {
        public Experiment()
        {
            this.name = "Experiment";
        }
    }

    public class Explore : Action
    {
        public Explore()
        {
            this.name = "Explore";
        }
    }

    public class Gather : Action
    {
        public Gather()
        {
            this.name = "Gather";
        }
    }


    public class Give : Action
    {
        public Give()
        {
            this.name = "Give";
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
        string NPCName;
        public Read()
        {
            this.name = "Read";
        }
    }

    public class Repair : Action
    {
        public Repair()
        {
            this.name = "Repair";
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
        public Take()
        {
            this.name = "Take";
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
