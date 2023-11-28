using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_2_Task_1
{
    public class CarBuilder : Builder
    {
        private Car car = new Car();

        public Car getResult()
        {
            Car result = car;

            reset();

            return result;

        }

        public Builder reset()
        {
            car = new Car();
            return this;
        }

        public Builder setEngine(string engine)
        {
            car.Engine = engine;
            return this;
        }

        public Builder setGPS()
        {
            car.GPS = "GPS";
            return this;
        }

        public Builder setSeats(int number)
        {
            car.Seats = number;
            return this;
        }

        public Builder setTripComputer()
        {
            car.TripComputer = "TripComputer";
            return this;
        }
    }
}
