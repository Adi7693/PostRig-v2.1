using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostRig_v2._1
{
    public class Spring : IVehicleComponent
    {
        Spring()
        {
            Type = VehicleComponentTypes.Spring;

            Key = Guid.NewGuid().ToString();
        }


        public Spring(string name): this()
        {
            Name = name;
        }

        public VehicleComponentTypes Type { get; }

        public string FileName { get; set; }

        public string Key { get; }

        public string Name { get; set; }



    }
}
