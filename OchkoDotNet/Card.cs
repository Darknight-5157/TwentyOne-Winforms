using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OchkoDotNet
{
    public class Card
    {
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public int Rank { get; set; }
        public int Suit { get; set; }
        public bool isPicture { get; set; }
        public string image { get; set; }
        public Card()
        {
            Rank = 0;
            Suit = 0;
            image = "";
        }
        public Card(int Rank, int Suit)
        {
            this.Rank = Rank;
            this.Suit = Suit;

            if (Rank < 6)
            {
                isPicture = true;
            }

            image = projectDirectory + "\\Sprites\\" + RankToString() + SuitToString() + ".png";
        }

        public string RankToString()
        {
            string temp = string.Empty;
            switch (Rank)
            {
                case 6:
                    temp = "SixOf";
                    break;
                case 7:
                    temp = "SevenOf";
                    break;
                case 8:
                    temp = "EightOf";
                    break;
                case 9:
                    temp = "NineOf";
                    break;
                case 10:
                    temp = "TenOf";
                    break;
                case 2:
                    temp = "JackOf";
                    break;
                case 3:
                    temp = "QueenOf";
                    break;
                case 4:
                    temp = "KingOf";
                    break;
                case 11:
                    temp = "AceOf";
                    break;
                default:
                    temp = " ";
                    break;
            }
            return temp;
        }

        public string SuitToString()
        {
            string temp = string.Empty;
            switch (Suit)
            {
                case 0:
                    temp = "Spades";
                    break;
                case 1:
                    temp = "Diamonds";
                    break;
                case 2:
                    temp = "Clubs";
                    break;
                case 3:
                    temp = "Hearts";
                    break;
                default:
                    temp = " ";
                    break;
            }
            return temp;
        }
    }
}
