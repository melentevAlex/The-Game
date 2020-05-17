using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class GenerateNumber
    {
        private string number;
        public string Number { get => number;}

        public void Generate()
        {
            Random rand = new Random();
            int count = rand.Next(3, 5);
            int numb = rand.Next((int)Math.Pow(10, count-1), (int)Math.Pow(10, count));
            number = numb.ToString();
        }
    }
    // 1 экземпляр
}
