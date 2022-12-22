using System;

namespace RPG05
{
    class Unit
    {
        // fields
        public string name;
        public int id;
        private int maxHealth;
        private int health;
        public static int nextId = 1;

        // constructor
        public Unit(string name, int maxHealth)
        {
            this.name = name;
            this.id = nextId;
            nextId++;

            this.maxHealth = maxHealth;
            this.health = maxHealth;

            // Make sure, that this is the last line of the constructor:
            ReportStatus();
        }

        // method
        public void ReportStatus()
        {
            Console.WriteLine($"Unit #{id}: {name} - {health}/{maxHealth} Health");
        }

        // property
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = Math.Max(0, Math.Min(value, maxHealth));
                ReportStatus();
            }
        }

        // finalizer
        ~Unit()
        {
            Console.WriteLine($"Unit #{id}: {name} got finalized.");
        }
    }
}