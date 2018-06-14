using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WodLibrary;
using Dapper;
using System.Data;

namespace WodCreatorUI
{
    public class DataAccess
    {
        public List<ExerciseModel> GetExercise(string ExerciseEquipment)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("WodDB")))
            {
 
                return connection.Query<ExerciseModel>("dbo.GetEquipmentType @ExerciseEquipment", new { ExerciseEquipment = ExerciseEquipment }).ToList();
                
            }
        }
    }
}
