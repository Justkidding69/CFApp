using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WodLibrary
{
    public class GirlsModel
    {
        public int id { get; set; }

        public string Girl { get; set; }

        public string Wod { get; set; }

        public string GirlInfo
        {
            get
            {
                return $"{Wod}";
            }
        }
    }
}
