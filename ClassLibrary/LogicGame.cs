using System;
using System.Collections.Generic;
using System.Text;
using game;

namespace game
{
    public class LogicGame
    {

        private string answer;
        private string number;
        private GenerateNumber gn = new GenerateNumber();
        public string Answer { get => answer; set => answer = value; }
        public string Number { get => number; }

        public LogicGame()
        {
            gn.Generate();
            if (CheckNum(gn.Number))
            {
                number = gn.Number;
            }
            else
            {
                gn.Generate();
            }

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
        public string CheckAnswer(string answer)
        {
            int a;
            if (!(int.TryParse(Answer, out a)))
            {
                throw new Exception("Введено не число");
            }
            
            if (Number.Length != Answer.Length)
            {
                throw new Exception("Длинна не равна");
            }
            if (!CheckNum(Answer))
            {
                throw new Exception("В ответе есть одинаковыe цифры");
            }
            else
            {
                return answer;
            }

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
        public string CheckAnswer(string answer)
        {




            int a;
            if (!int.TryParse(Answer, out a))
            {
                throw new Exception("Введено не число");
            }

            if (Number.Length != Answer.Length)
            {
                throw new Exception("Длинна не равна");
            }
            if (!CheckNum(Answer))
            {
                throw new Exception("В ответе есть одинаковыe цифры");
            }
            else
            {
                return answer;
            }

        }
        */





    }
}