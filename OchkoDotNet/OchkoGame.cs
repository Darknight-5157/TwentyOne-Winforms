using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OchkoDotNet
{
    internal class OchkoGame
    {
        public int playerScore, botScore;

        public int playerMoney = 500, botMoney = 3000;

        public int bet;

        public int playerPicturesCounter, botPicturesCounter;

        public byte win;

        public List<Card> deck = new List<Card>();

        public List<Card> playerCards;
        public List<Card> botCards;

        public void Start()
        {
            playerCards = new List<Card>();
            botCards = new List<Card>();

            playerPicturesCounter = 0;
            botPicturesCounter = 0;

            playerScore = 0;
            botScore = 0;

            for (int i = 0; i < 4; i++)         // Определение масти карт
            {
                for (int j = 2; j < 5; j++)     // Инициализация карт с картинками
                {
                    deck.Add(new Card(j, i));
                }

                for (int j = 6; j < 12; j++)    // Инициализация карт без картинок
                {
                    deck.Add(new Card(j, i));
                }
            }

            for (int i = 0; i < 36; i++)        // Тасовка колоды
            {
                Card temp = new Card();
                Random rand = new Random();
                int j = rand.Next(0, 35);

                temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        public void TakeCard()
        {
            int index = playerCards.Count;
            playerCards.Add(deck[index]);

            playerScore = 0;
            for (int i = 0; i < playerCards.Count; i++)         // Подсчёт очков игрока
            {
                playerScore += playerCards[i].Rank;
            }

            if (deck[index].isPicture)              // Если игроку досталась карта с картинкой, счётчик карт с картинками инкрементируется
                playerPicturesCounter++;

            if (playerPicturesCounter == 5)
            {
                MessageBox.Show(
      "У вас 5 картинок!\n" +
      "Это очко!",
      "Сообщение",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information,
      MessageBoxDefaultButton.Button1,
      MessageBoxOptions.RightAlign);

                playerScore = 21;
            }

            if (playerScore > 21)
            {
                for (int i = 0; i < playerCards.Count; i++)                     // В случае перебора делает стоимость туза равной одному очку
                {
                    if (playerCards[i].Rank == 11)
                    {
                        playerScore -= 10;
                        break;
                    }
                }
                if (playerCards[0].Rank == 11 && playerCards[1].Rank == 11)     // В случае, если первые 2 карты - тузы, игрок выигрывает
                {
                    MessageBox.Show(
       "У вас 2 туза!",
       "Сообщение",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.RightAlign);

                    playerScore = 22;
                }
            }
        }

        public void BotTakeCards()
        {
            bool botExit = false;

            for (int i = 0; !botExit; i++)
            {
                int index = botCards.Count + 8;
                botCards.Add(deck[index]);

                botScore = 0;
                for (int j = 0; j < botCards.Count; j++)         // Подсчёт очков бота
                {
                    botScore += botCards[j].Rank;
                }

                if (deck[index].isPicture)      // Если боту досталась карта с картинкой, счётчик карт с картинками инкрементируется
                    botPicturesCounter++;

                if (botPicturesCounter == 5)    // Проверка на то, собрал ли бот 5 карт с картинками
                {
                    MessageBox.Show(
          "У соперника 5 картинок!\n" +
          "Это очко!",
          "Сообщение",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information,
          MessageBoxDefaultButton.Button1,
          MessageBoxOptions.RightAlign);

                    botScore = 21;
                }

                if (botScore >= 16)             // не давать боту карт, если у него больше 16 очков
                {
                    botExit = true;

                    for (int j = 0; j < botCards.Count; j++)                     // В случае перебора делает стоимость туза равной одному очку
                    {
                        if (botCards[j].Rank == 11)
                        {
                            botScore -= 10;
                            botCards[j].Rank = 1;
                            botExit = false;
                        }
                    }

                    if (botCards[0].Rank == 11 && botCards[1].Rank == 11)     // В случае, если первые 2 карты - тузы, бот выигрывает
                    {
                        MessageBox.Show(
           "У соперника 2 туза!",
           "Сообщение",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.RightAlign);

                        botScore = 22;
                    }

                }
            }
        }

        public void Result()
        {
            if (playerCards[0].Rank == 11 && playerCards[1].Rank == 11)
            {
                MessageBox.Show(
      "У вас 2 туза!\n" +
      "Вы выиграли",
      "Сообщение",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information,
      MessageBoxDefaultButton.Button1,
      MessageBoxOptions.RightAlign);

                win = 2;
            }
            else if (botCards[0].Rank == 11 && botCards[1].Rank == 11)
            {
                MessageBox.Show(
      "У соперника 2 туза!\n" +
      "Вы проиграли",
      "Сообщение",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information,
      MessageBoxDefaultButton.Button1,
      MessageBoxOptions.RightAlign);

                win = 0;
            }
            else if (playerScore == botScore)
            {
                MessageBox.Show(
     "У вас ничья!\n",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                win = 1;
            }
            else if (playerScore > 21 && botScore > 21)
            {
                MessageBox.Show(
     "У вас обоих перебор!\n" +
     "Ничья!",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                win = 1;
            }
            else if (playerScore > 21)
            {
                MessageBox.Show(
     "У вас перебор!\n" +
     "Вы проиграли",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                win = 0;
            }
            else if (botScore > 21)
            {
                MessageBox.Show(
     "У соперника перебор!\n" +
     "Вы выиграли",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                win = 2;
            }
            else if (playerScore == 21)
            {
                MessageBox.Show(
     "У вас очко!\n" +
     "Вы выиграли",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                win = 2;
            }
            else if (botScore == 21)
            {
                MessageBox.Show(
     "У соперника очко!\n" +
     "Вы проиграли",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                win = 0;
            }
            else if (playerScore < 21 && botScore < 21)
            {
                int playerDifference, botDifference;

                playerDifference = 21 - playerScore;
                botDifference = 21 - botScore;

                if (playerDifference < botDifference)
                {
                    MessageBox.Show(
     "Вы ближе к очку чем соперник!\n" +
     "Вы победили",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                    win = 2;
                }
                if (botDifference < playerDifference)
                {
                    MessageBox.Show(
     "Соперник ближе к очку чем вы!\n" +
     "Вы проиграли",
     "Сообщение",
     MessageBoxButtons.OK,
     MessageBoxIcon.Information,
     MessageBoxDefaultButton.Button1,
     MessageBoxOptions.RightAlign);

                    win = 0;
                }
            }

            switch (win)            // Изменение баланса игроков
            {
                case 2:
                    playerMoney += bet;
                    botMoney -= bet;
                    break;
                case 1:
                    break;
                case 0:
                    playerMoney -= bet;
                    botMoney += bet;
                    break;
            }

        }

        public OchkoGame()
        {
            Start();
        }
    }
}
