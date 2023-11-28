using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_2_Task_1
{
    public interface Builder
    {
        Builder reset();
        Builder setSeats(int number);
        Builder setEngine(string engine);
        Builder setTripComputer();
        Builder setGPS();
        Car getResult();







    }
}
