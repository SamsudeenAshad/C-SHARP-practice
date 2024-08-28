using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCar
{
    public class car
    {
        int id {  get; set; }

        private string brand { get; set; }
        private string color { get; set; }
        private string model { get; set; }

        car(carBuilder  carBuilder)
        {
            this.id = carBuilder.id;
            this.brand = carBuilder.brand;
            this.color = carBuilder.color;
            this.model = carBuilder.model;
        }

        public void Display()
        {
            Console.WriteLine($"{id} {brand} {color} {model}");
        }

        
    }

    public class carBuilder
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public string model { get; set; }


        public carBuilder Id(int id)
        {
            this.id = id;
            return this;
        }

        public carBuilder Brand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public carBuilder Color(string color)
        {
            this.color = color;
            return this;
        }

        public carBuilder Mode(string mode)
        {
            this.mode = Mode;
            return this;
        }

        public car Build()
        {
            return new car(this);
        }

    }
}
