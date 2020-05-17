using System;
using System.Collections.Generic;
using System.Text;

namespace game
{
    class LogicGame
    {

        private string answer;
        private string number;
        private GenerateNumber gn = new GenerateNumber();
        public string Answer { get => answer; set => answer = value; }
        public string Number { get => number; }

        public LogicGame()
        {
            do
            {
                gn.Generate();
            } while (!CheckNum(gn.Number));
            number = gn.Number;
        }
        public bool CheckNum(string num)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        return false;
                    }

                }
            }

            return true;
        }
        public string CheckAnswer()
        {
            int a;
            if (!int.TryParse(Answer, out a))
            {
                return "Введено не число";
            }
            if (Number.Length != Answer.Length)
            {
                return "Длинна не равна";
            }
            if (!CheckNum(Answer))
            {
                return "В ответе есть одинаковый цифры";
            }
            return "ok";

        }


        public (int,int) Compare()
        {
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < Answer.Length; i++)
            {
                for (int j = 0; j < Answer.Length; j++)
                {
                    if (Number[i] == Answer[j])
                    {
                        if (i == j)
                        {
                            bulls++;
                        }
                        else
                        {
                            cows++;
                        }
                    }
                }
            }
            return (bulls, cows);
        }


        public bool IsEndGame()
        {
            return answer == number;
        }

        /*
        public void Compare()
        {
            int bulls = 0;
            int cows = 0;

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == number[i])
                {
                    bulls++;
                }
            }

            string sumstr = null;
            string sumstr2 = null;
            int count = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == number[i])
                {
                    continue;
                }
                else
                {
                    sumstr += answer[i];
                    sumstr2 += number[i];
                }
            }
            for (int k = 0; k < sumstr.Length; k++)
            {
                for (int h = 0; h < sumstr.Length; h++)
                {
                    if (sumstr[count] == sumstr2[h])
                    {
                        cows++;
                    }
                }
                count++;
            }

            Console.WriteLine($"{bulls} bulls");
            Console.WriteLine($"{cows} cows");

            // метод в этом классе answer computer сколько быков сколько коров
            // булевский метод окончания игры

        }
        */
    }
}