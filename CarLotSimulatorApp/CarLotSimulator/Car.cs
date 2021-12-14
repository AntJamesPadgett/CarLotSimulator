using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   public class Car
    {
        public Car(string v1, string v2, int v3, string v4, string v5, string v6)
        {
        }

        public  int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine(EngineNoise);


        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine(HonkNoise);
        }


    }
}
