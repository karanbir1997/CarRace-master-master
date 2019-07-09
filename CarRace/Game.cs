using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public partial class maingame : Form
    {
        
        cars[] cars = new cars[3];
        Bettor[] players = new Bettor[4];
        Random randmon = new Random();
        int bet = 1;
        public maingame()
        {
            InitializeComponent();
            playerplay();
        }
        void goRace()
        {
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Racebtn_Click(object sender, EventArgs e)
        {
            goRace();
            racebtn.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].First_Race())
                {
                    stopRace(i);
                    break;
                }
            }

        }
        

        private void betbtn_Click(object sender, EventArgs e)
        {
            if (PeteRAdio.Checked)
            {
                cars[0].Bets((int)playerud.Value, (int)racerud.Value);
                cars[0].racerupdate();
            }
            if (samradio.Checked)
            {
                cars[1].Bets((int)playerud.Value, (int)racerud.Value);
                cars[1].racerupdate();
            }
            if (Jeffradio.Checked)
            {
                cars[2].Bets((int)playerud.Value, (int)racerud.Value);
                cars[2].racerupdate();
            }
        }

       


        public void stopRace(int winnerplayer)
        {
            timer1.Stop();
            timer1.Dispose();
            MessageBox.Show("First car is " + winnerplayer);
            foreach (var player in cars)
            {
                player.playerwin(winnerplayer);
            }
            foreach (var car in players)
            {
                car.startPosi();
            }
            racebtn.Enabled = true;
        }
        public void playerplay()
        {
            players[0] = new Bettor()
            {
                carPicturebox = RacerPB1,
                start_race = Pbrace.Left,
                Fullrace = Pbrace.Width - RacerPB1.Width,
                rad = randmon
            };
            players[1] = new Bettor()
            {
                carPicturebox = RacerPB2,
                start_race = Pbrace.Left,
                Fullrace = Pbrace.Width - RacerPB2.Width,
                rad = randmon
            };
            players[2] = new Bettor()
            {
                carPicturebox = racerPb3,
                start_race = Pbrace.Left,
                Fullrace = Pbrace.Width - racerPb3.Width,
                rad = randmon
            };
            players[3] = new Bettor()
            {
                carPicturebox = racerpb4,
                start_race = Pbrace.Left,
                Fullrace = Pbrace.Width - racerpb4.Width,
                rad = randmon
            };


            cars[0] = new cars("peter", 50, PeteRAdio, player1Label);
            cars[1] = new cars("sam", 50, samradio, player2Label);
            cars[2] = new cars("jef", 50, Jeffradio, player3Label);

            foreach (var guy in cars)
            {
                guy.Bets(0, 0);
                guy.racerupdate();
            }
            minimumBetLabel.Text = "1";
            playerud.Minimum = bet;
        }

        private void player2Label_Click(object sender, EventArgs e)
        {

        }

        private void player1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
