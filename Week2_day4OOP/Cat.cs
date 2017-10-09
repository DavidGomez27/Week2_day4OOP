using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day4OOP
{
    class Cat
    {
        //STATES
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry;

        //Properties
        public string Name
        {
            get { return this.name;  } //get sends to program
            set { this.name = value; }//set brings from program

        }


        //BEHAVIORS 

        //Constructors
        public Cat()
        {
           //default constructor because it takes no parameters in the parenthesis
        }


        //overloading a constructor
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //Methods

        public void Eat()
        {
            if (isHungry == true)
            {
                isHungry = false;
            }


            Console.WriteLine("Is the cat hungry? " + isHungry);

        }


        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;
            }

            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);

        }


    }
}
