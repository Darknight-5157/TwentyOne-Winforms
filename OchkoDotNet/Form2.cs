using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OchkoDotNet.Card;
using static System.Net.Mime.MediaTypeNames;

namespace OchkoDotNet
{
    public partial class Form2 : Form
    {
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public int playerCardsCounter = 0;

        OchkoGame ochkoGame = new OchkoGame();

        Bitmap[] background = new Bitmap[3];

        int count = 0;

        public Form2()
        {
            InitializeComponent();
            background[0] = new Bitmap(projectDirectory + "\\Sprites\\BlueTable.png");
            background[1] = new Bitmap(projectDirectory + "\\Sprites\\RedTable.png");
            background[2] = new Bitmap(projectDirectory + "\\Sprites\\BlackTable.png");

            balanceBox.Text = "Ваш баланс  - " + Convert.ToString(ochkoGame.playerMoney);
            botBalanceBox.Text = "Баланс бота - " + Convert.ToString(ochkoGame.botMoney);
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {
            if (ochkoGame.bet == 0)
            {
                MessageBox.Show(
            "Укажите ставку и повторите попытку!",
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);
            }
            else
            { 
            playerCardsCounter++;
            dropBtn.Show();

            ochkoGame.TakeCard();
            switch (playerCardsCounter)             // Вывод изображения карт
            {
                case <= 1:
                    card1.ImageLocation = ochkoGame.playerCards[0].image;
                    break;
                case <= 2:
                    card2.ImageLocation = ochkoGame.playerCards[1].image;
                    break;
                case <= 3:
                    card3.ImageLocation = ochkoGame.playerCards[2].image;
                    break;
                case <= 4:
                    card4.ImageLocation = ochkoGame.playerCards[3].image;
                    break;
                case <= 5:
                    card5.ImageLocation = ochkoGame.playerCards[4].image;
                    break;
                case <= 6:
                    card6.ImageLocation = ochkoGame.playerCards[5].image;
                    break;
                case <= 7:
                    card7.ImageLocation = ochkoGame.playerCards[6].image;
                    break;
                case <= 8:
                    card8.ImageLocation = ochkoGame.playerCards[7].image;
                    break;
            }

            scoreBox.Text = "Очков         - " + Convert.ToString(ochkoGame.playerScore); // Вывод количества очков у игрока

            if (playerCardsCounter == 8 || ochkoGame.playerScore >= 21)    // Скрыть кнопку взятия карт, если все 8 карт уже выведены, или у игрока перебор/очко
                takeBtn.Hide();
            }
        }

        private async void dropBtn_Click(object sender, EventArgs e)
        {
            takeBtn.Hide();
            dropBtn.Hide();

            ochkoGame.BotTakeCards();

            await Task.Delay(1500);
            botScoreBox.Text = "Очков  бота - " + Convert.ToString(ochkoGame.botScore); // Вывод количества очков у бота

            await Task.Delay(2000);
            gameResult();
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            ochkoGame.bet = Convert.ToInt32(betInBox.Text);
            if (ochkoGame.bet > ochkoGame.playerMoney || ochkoGame.bet > ochkoGame.botMoney)    // Проверка на то, что вводимая игроком ставка не превышает
            {                                                                                   // его баланс или баланс бота                                                                           
                MessageBox.Show(
         "Ставка не может быть больше баланса!",
         "Сообщение",
         MessageBoxButtons.OK,
         MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button1,
         MessageBoxOptions.RightAlign);
            }
            else if (ochkoGame.bet < 0)
            {
                MessageBox.Show(
         "Ставка не может быть отрицательной!",
         "Сообщение",
         MessageBoxButtons.OK,
         MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button1,
         MessageBoxOptions.RightAlign);
            } 
            else if (ochkoGame.bet == 0)
            {
                MessageBox.Show(
         "Ставка не может быть нулевой!",
         "Сообщение",
         MessageBoxButtons.OK,
         MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button1,
         MessageBoxOptions.RightAlign);
            }
            else
            {
                betBtn.Hide();              // сокрытие элементов ввода ставки
                betInBox.Hide();

                bankBox.Text = "Банк - " + Convert.ToString(ochkoGame.bet * 2);     // вывод банка 

                balanceBox.Text = "Ваш баланс  - " + Convert.ToString(ochkoGame.playerMoney - ochkoGame.bet);  // Вывод нового баланса
                botBalanceBox.Text = "Баланс бота - " + Convert.ToString(ochkoGame.botMoney - ochkoGame.bet);

            }
        }

        public void gameResult()     // Определение результатов игры и обнуление различных параметров
        {
            ochkoGame.Result();
            ochkoGame.Start();

            playerCardsCounter = 0;     //обнуление счётчика карт на руках у игрока

            balanceBox.Text = "Ваш баланс  - " + Convert.ToString(ochkoGame.playerMoney);  // Вывод нового баланса
            botBalanceBox.Text = "Баланс бота - " + Convert.ToString(ochkoGame.botMoney);

            if (ochkoGame.botMoney <= 0)
                upgradeBtn.Show();

            if (ochkoGame.playerMoney <= 0)
                restartBtn.Show();

            betBtn.Show();          // Отображение ранее скрытых элементов управления
            betInBox.Show();
            takeBtn.Show();

            ochkoGame.bet = 0;                          // Обнуление ставки
            bankBox.Text = "Банк - 0";     

            botScoreBox.Text = "Очков  бота - 0";    // Обнуление очков
            scoreBox.Text = "Очков         - 0";

            card1.ImageLocation = ""; // Сброс отображения карт на экране
            card2.ImageLocation = "";
            card3.ImageLocation = "";
            card4.ImageLocation = "";
            card5.ImageLocation = "";
            card6.ImageLocation = "";
            card7.ImageLocation = "";
            card8.ImageLocation = "";
        }

        private void begemot_Click(object sender, EventArgs e)
        {
            BackgroundImage = background[count % 3];
            count++;
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            upgradeBtn.Hide();
            restartBtn.Hide();
            ochkoGame.playerMoney = 300;
            ochkoGame.botMoney = 3000;

            balanceBox.Text = "Ваш баланс  - " + Convert.ToString(ochkoGame.playerMoney);
            botBalanceBox.Text = "Баланс бота - " + Convert.ToString(ochkoGame.botMoney);

            ochkoGame.Start();
        }
    }
}
