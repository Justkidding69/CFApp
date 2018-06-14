using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WodLibrary
{
    public class ExerciseModel
    {
        public int id { get; set; }

        public string ExerciseName { get; set; }

        public string ExerciseEquipment { get; set; }

        public string ExerciseID
        {
            get
            {
                return $"{ExerciseName} ({ExerciseEquipment})";
            }
        }

    }

}
