using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostRig_v2._1
{
    class VehicleBody : IVehicleComponent
    {
        VehicleBody()
        {
            Type = VehicleComponentTypes.Body;
            Key = Guid.NewGuid().ToString();
        }

        public VehicleBody(string name): this()
        {
            Name = name;
        }

        public VehicleComponentTypes Type { get; }

        public string FileName { get; set; }

        public string Key { get; }

        public string Name { get; set; }

        public double Mass { get; set; }

    }
}
