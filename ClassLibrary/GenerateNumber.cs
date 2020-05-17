using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    public class GenerateNumber
    {
        private string number;
        public string Number { get => number;}

        public void Generate()
        {
            Random rand = new Random();
            int count = rand.Next(4, 4);
            int numb = rand.Next((int)Math.Pow(10, count-1), (int)Math.Pow(10, count));
            number = numb.ToString();
        }
    }
}
