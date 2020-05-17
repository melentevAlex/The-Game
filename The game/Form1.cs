using System;
using The_game;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game;

namespace The_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        GenerateNumber generateNumber = new GenerateNumber();
        LogicGame logicGame = new LogicGame();

        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                logicGame.Answer = AnswerTextBox.Text;
                logicGame.CheckAnswer(logicGame.Answer);
                (int, int) c = logicGame.Compare();
                CowLabel.Text = c.Item2.ToString();
                BullLabel.Text = c.Item1.ToString();
                if (BullLabel.Text == logicGame.Number.Length.ToString())
                {
                    MessageBox.Show("ю win мазафака");
                }
  
            }
            catch (Exception edr)
            {
                MessageBox.Show(edr.Message);

            }



        }

        private void buttonRuls_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ruls r = new Ruls();
            r.Show();
        }
    }
}
