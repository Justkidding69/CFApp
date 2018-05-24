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

        public List<ExerciseModel> Movement { get; set; } = new List<ExerciseModel>();

        public List<CardioModel> HighPulse { get; set; } = new List<CardioModel>();

        public List<MuscleModel> MuscleGroup { get; set; } = new List<MuscleModel>();

        public List<LadiesModel> Ladies { get; set; } = new List<LadiesModel>();
    }
}
