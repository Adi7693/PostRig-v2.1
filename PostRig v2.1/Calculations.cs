using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostRig_v2._1
{
    public class Calculations
    {







        private double _startTime;

        public double StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                if (!value.Equals(_startTime))
                {
                    _startTime = value;
                }
            }
        }


        private double _timeStep;

        public double TimeStep
        {
            get
            {
                return _timeStep;
            }
            set
            {
                if (!value.Equals(_timeStep))
                {
                    _timeStep = value;
                }
            }
        }


        private double _endTime;

        public double EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {

                if (!value.Equals(_endTime))
                {
                    if (value > StartTime)
                    {
                        _endTime = value;
                    }
                }
            }
        }





    }
}
