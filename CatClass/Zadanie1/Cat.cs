using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Cat
    {
        private string name;
        private double weight;

        public Cat(string CatName)
        {
            Name = CatName;
        }
        public void Meow()
        {
            Console.WriteLine($"{name}: МЯУ!!!");
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }
                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправальное имя для кота!");
                }
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if(value !=0)
                {
                    weight = value;
                }
            }
        }
        public void AddWeight(double newweight)
        {
            if (newweight >= 0)
            {
                weight = newweight;
            }
            else
            {
                Console.WriteLine($"Вес кота не может быть отрицательным!");
            }
        }
        public void Weights()
        {
            Console.WriteLine($"Вес {name} : {weight}кг");
        }
    }
}
