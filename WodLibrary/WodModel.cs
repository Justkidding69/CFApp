using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WodLibrary
{
    public class WodModel
    {
        public string WodType { get; set; }

        public string WodName { get; set; }

        public List<Exercise> Movement { get; set; } = new List<Exercise>();

        public List<Cardio> HighPulse { get; set; } = new List<Cardio>();

        public List<Muscle> MuscleGroup { get; set; } = new List<Muscle>();
    }
}
