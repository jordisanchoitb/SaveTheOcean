using System;

namespace SaveTheOcean
{
    public class Player
    {
        public string Name { get; set; }
        public int Experience { get; set; }

        public Player(string name, int experience)
        {
            this.Name = name;
            this.Experience = experience;
        }
    }
}
