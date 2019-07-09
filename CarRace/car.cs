using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    class cars//THIS CODING USED FOR ALL BUTTONS IN CAR RACE//
    {
        public int amtmoney;
        public RadioButton BetterRb;
        public Label Betterlb;
        public string Bettername;
        public player Betracer;
        

      


        public void nonbet()
        {
            Betracer.amt = 0;
        }
        public cars(string car, int mon, RadioButton playerbtn, Label playerLB)
        {
            Bettername = car;
            amtmoney = mon;
            BetterRb = playerbtn;
            Betterlb = playerLB;
            Betracer = new player(this);
        }//bets
        public bool Bets(int playermoney, int playerwin)
        {
            Betracer.amt = playermoney;
            Betracer.car_racer = playerwin;
            if (amtmoney >= playermoney) return true;
            return false;
        }

        public void racerupdate()
        {
            Betterlb.Text = Betracer.BetStatus();
            BetterRb.Text = Bettername + " has " + amtmoney + " bucks";
        }//THIS CODING IS USED FOR SHOW WHO PLAYER WIN// 
        public void playerwin(int winplayer)
        {
            amtmoney += Betracer.Winner(winplayer);
            nonbet();
            racerupdate();
        }
    }
}
