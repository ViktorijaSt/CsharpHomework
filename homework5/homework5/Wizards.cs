using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Wizards
    {

        public string Name;
        public int PowerLevel;
        public int Age;
        public DateTime DateOfAdmission;
        public bool GraduationStatus;

        public Wizards(string Name, int PowerLevel, int Age, DateTime DateOfAdmission, bool GraduationStatus)

        {
            this.Name = Name;
            this.PowerLevel = PowerLevel;
            this.Age = Age;
            this.DateOfAdmission = DateOfAdmission;
            this.GraduationStatus = GraduationStatus;
        }
    }

}
