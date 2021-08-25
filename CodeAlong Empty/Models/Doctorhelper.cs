using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlong_Empty.Models
{
    public class Doctorhelper
    {
        public static string Diagnose(string temp, string unit)
        {
            float temperature = float.Parse(temp);

            if (unit=="fahrenheit")
                temperature = (temperature - 32) * 5 / 9;

            if (temperature < 37.5)
            {
                if (temperature < 33.5)
                {

                    return temperature+"Oh, my God, your temperature is too low.";
                }
                else
                {
                    return temperature + "It's ok! No problem";
                }
            }
            else
            {
                return temperature + "Sorry! You are fever...";
            }

        }
    }
}
