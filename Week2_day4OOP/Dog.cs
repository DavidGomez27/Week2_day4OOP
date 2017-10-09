using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day4OOP
{
    class Dog
    {
        //fields
        private string hairLength;
        private float height;
        private string runningSpeed;
        private double weight;

        //Properties\

        public string HairLength
        {
            get { return this.hairLength; }
            set {this.HairLength = value; }
        }

        public float Height
        {
            get { return this.height; }
            set { this.Height = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.RunningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.Weight = value; }
        }



        //Constructors
        public Dog()
        {

        }

        public Dog(string hairLength, float height)
        {
            this.hairLength = hairLength;
            this.height = height;
            
        }

        //Methods

        public void Run()
        {
            runningSpeed = "getting faster.";
            weight--;
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight = weight - 0.1;
        }

        public void Groom()
        {
            hairLength = "all cleaned up.";
        }




    }
}
