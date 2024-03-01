using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
