using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsColony2030.Models
{
    public class User
    {
        public string Name { get; set; }

        //Gender
        public bool IsMale { get; set; }

        //Weight in lbs (will be converted kg)
        public double Weight { get; set; }

        //Height in inches (will be converted to cm)
        public double Height { get; set; }

        //Height in inches (will be converted to cm)
        public int Age { get; set; }

        public int TotalCalories { get; set; }
        public int CurrentCalories { get; set; }
    }
}
