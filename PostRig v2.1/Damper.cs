using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostRig_v2._1
{
    public class Damper : IVehicleComponent
    {
        Damper()
        {
            Type = VehicleComponentTypes.Damper;

            Key = Guid.NewGuid().ToString();
        }

        public Damper(string name)
        {
            Name = name;
        }

        public VehicleComponentTypes Type { get; }

        public string FileName { get; set; }
        public string Key { get; }
        public string Name { get; set; }


    }
}
