using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_2_Task_1
{
    public class Director
    {

        public Builder makeSUV(Builder builder)
        {

            return builder
                .reset()
                .setSeats(2)
                .setEngine("Engine");
        }

        public Builder makeSports(Builder builder) {
            
            return builder
                .reset()
                .setSeats(2)
                .setEngine("Engine")
                .setTripComputer()
                .setGPS();
        }




    }
}
