using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostRig_v2._1
{
    public class Project
    {
        public bool BodyNeedsToAdd;
        public bool SpringNeedsToAdd;
        public bool DamperNeedsToAdd;


        public Project()
        {
            BodyNeedsToAdd = false;
            SpringNeedsToAdd = false;
            DamperNeedsToAdd = false;
        }

        private List<IVehicleComponent> _bodies;
        public List<IVehicleComponent> Bodies
        {
            get
            {
                if(_bodies == null)
                {
                    _bodies = new List<IVehicleComponent>();
                }

                return _bodies;
            }
        }

        private List<IVehicleComponent> _springs;
        public List<IVehicleComponent> Springs
        {
            get
            {
                if(_springs == null)
                {
                    _springs = new List<IVehicleComponent>();
                }

                return _springs;
            }
        }

        private List<IVehicleComponent> _damper;
        public List<IVehicleComponent> Dampers
        {
            get
            {
                if(_damper == null)
                {
                    _damper = new List<IVehicleComponent>();
                }

                return _damper;
            }
        }

        public void AddBody(IVehicleComponent component)
        {
            if(BodyNeedsToAdd && component.Type == VehicleComponentTypes.Body)
            {
                Bodies.Add(component);

                BodyNeedsToAdd = false;
            }
        }

        public void AddSpring(IVehicleComponent component)
        {
            if(SpringNeedsToAdd && component.Type == VehicleComponentTypes.Spring)
            {
                Springs.Add(component);

                SpringNeedsToAdd = false;
            }
        }

        public void AddDamper(IVehicleComponent component)
        {
            if (DamperNeedsToAdd && component.Type == VehicleComponentTypes.Damper)
            {
                Dampers.Add(component);

                DamperNeedsToAdd = false;
            }
        }

        public string GetValidName(VehicleComponentTypes type)
        {
            string name = type.ToString() + " ";

            switch (type)
            {
                case VehicleComponentTypes.Body:
                    {
                        name += (Bodies.Count + 1).ToString();
                    }
                    break;
                case VehicleComponentTypes.Spring:
                    {
                        name += (Springs.Count + 1).ToString();
                    }
                    break;
                case VehicleComponentTypes.Damper:
                    {
                        name += (Dampers.Count + 1).ToString();
                    }
                    break;
                default:
                    break;
            }

            return name;
        }

    }
}
