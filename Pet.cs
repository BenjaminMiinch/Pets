using System;
namespace Pets
{
    public class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        //Constructor

        public Pet(string type1, string name1, string owner1, double weight1)
        {
            name = name1;

            owner = owner1;

            weight = weight1;

            type = type1;
        }

        //Get Tag function
        public string getTag()
        { 
            return "If lost, call " + owner;
        }

    }
}
