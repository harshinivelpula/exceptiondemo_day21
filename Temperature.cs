using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class Temperature
    {
        int temperature = 0;
        public void ShowTemp()
        {
            if(temperature==0)
            {
                throw new TemperatureIsZeroException("Temperature is zero");
            }
            else
            {
                Console.WriteLine("Temperature is" + temperature);
            }
        }
    }
}
