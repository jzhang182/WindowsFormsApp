using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Form2: Form
    {
        private int handSize = 2;
        private int currentCard;
        private int playerValue = 0;
        private readonly int hostValue = 0;
        private readonly int hostConcealed = 0;
        private readonly Random deck = new Random();
        public Form2()
        {
            Button hostTopCard = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(60, 10),
                Text = deck.Next(1, 14).ToString()
            };
            hostValue += Convert.ToInt32(hostTopCard.Text);
            hostConcealed = deck.Next(1, 14);
            hostValue += hostConcealed;
            this.Controls.Add(hostTopCard);
            Button hostConcealedCard = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(10, 10),
                Text = ""
            };
            this.Controls.Add(hostConcealedCard);

            Button firstCard = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(10, 50),
                Text = deck.Next(1, 14).ToString()
            };
            playerValue += Convert.ToInt32(firstCard.Text);
            Button secondCard = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(60, 50),
                Text = deck.Next(1, 14).ToString()
            };
            playerValue += Convert.ToInt32(secondCard.Text);
            this.Controls.Add(firstCard);
            this.Controls.Add(secondCard);

            Button drawCard = new Button
            {
                Size = new Size(80, 40),
                Location = new Point(10, 100),
                Text = "Draw"
            };
            this.Controls.Add(drawCard);

            Button ShowUp = new Button
            {
                Size = new Size(80, 40),
                Location = new Point(100, 100),
                Text = "Show"
            };
            this.Controls.Add(ShowUp);

            drawCard.Click += new EventHandler(drawCard_Click);
            ShowUp.Click += new EventHandler(ShowUp_Click);
        }
        private void drawCard_Click(object sender, EventArgs e)
        {
            currentCard = deck.Next(1, 14);
            MessageBox.Show("New card drawn:" + currentCard.ToString());
            Button newCard = new Button
            {
                Size = new Size(40, 40),
                Location = new Point(10 + 50 * handSize , 50),
                Text = currentCard.ToString()
            };
            handSize += 1;
            this.Controls.Add(newCard);
            playerValue += currentCard;
            if ( playerValue > 21 )
            {
                MessageBox.Show("Over 21, you lost");
            }
        }
        private void ShowUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Host Value:" + hostValue.ToString()+ "\n" + "Player Value:" + playerValue.ToString());
            if ( playerValue > hostValue )
            {
                MessageBox.Show("You win!");
            }
            else if (playerValue == hostValue)
            {
                MessageBox.Show("Tie!");
            }
            else
            {
                MessageBox.Show("You lose!");
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
