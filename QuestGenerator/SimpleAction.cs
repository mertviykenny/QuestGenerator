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
        public Kill()
        {
            this.name = "Kill";
        }
    }; 
    public class Capture : Action
    {
        public Capture()
        {
            this.name = "Capture";
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
        public Escort()
        {
            this.name = "Escort";
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
        public Listen()
        {
            this.name = "Listen";
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
            this.name = "Repair";
        }
    };


    public class Report : Action
    {
        public Report()
        {
            this.name = "Report";
        }
    };

    public class Spy : Action
    {
        public Spy()
        {
            this.name = "Spy";
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
