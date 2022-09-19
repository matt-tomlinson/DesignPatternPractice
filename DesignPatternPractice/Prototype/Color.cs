using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Prototype {
    public class Color : ColorPrototype {
        int red;
        int green;
        int blue;

        public Color(int red, int green, int blue) {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override ColorPrototype? Clone() {
            Console.WriteLine($"Cloning color RGB: {red,3},{green,3},{blue,3}");

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
