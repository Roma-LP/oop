﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB_05
{
    class Strawberry:Tovar
    {
        int Satiety { get; set; }  // сытость
        Strawberry(int satiety) : base("Unknow", 1)
        {
            Satiety = satiety;
        }
        public Strawberry(int satiety, string name, int count) : base(name, count)
        {
            Satiety = satiety;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Количесвто сытости:\t" + Satiety);
        }
    }
}
