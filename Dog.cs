using System;
namespace Pets
{
    public class Dog : Pet
    {
        public string name1; 
        public string owner1;
        public double weight1;
        //constuctor

        public Dog(string name, string owner, double weight) : base(string.Empty, name, owner, weight)
        {
            name = name1;
            owner = owner1;
            weight = weight1;
        }

        public string bark(int count)     //count for number of barks 
        {
            string bark = "";

            for (int i = 0; i < count; i++)     //loop to display bark 'count ' many times
            {
                bark = bark + "bark!";
            }
            return bark;      
        }           
    }
}