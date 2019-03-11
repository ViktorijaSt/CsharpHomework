using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Creatures
    {
        public string name;
        public int age;
        public int powerLevel;
        public bool infoTamed;
        public Creatures(string name, int age, int powerLevel, bool infoTamed)

        {
            this.name = name;
            this.age = age;
            this.powerLevel = powerLevel;
            this.infoTamed = infoTamed;
        }
    }
}
