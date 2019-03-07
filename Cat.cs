using System;
namespace Pets
{
    public class Cat : Pet
    {
        public string name1;
        public string owner1;
        public double weight1;
        //constuctor

        public Cat(string name, string owner, double weight) : base(string.Empty, name, owner, weight)
        {
            name = name1;
            owner = owner1;
            weight = weight1;

        }

        public string meow(int count)     //count for number of meows
        {
            string meow = "";

            for (int i = 0; i < count; i++)     //loop to display meow 'count ' many times
            {
                meow = meow + "meow.";
            }
            return meow;

        }

    }
}
