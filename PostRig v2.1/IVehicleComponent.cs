using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostRig_v2._1
{
    public interface IVehicleComponent
    {
        VehicleComponentTypes Type {get;}

        string FileName { get; set; }

        string Key { get; }

        string Name { get; set; }

    }
}
