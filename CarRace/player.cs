using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrace
{
    class player
    {
        public int amt;
        public int car_racer;
        public cars bet_money;

      //THIS CODING IS USED BETTING ON CAR//
        public string BetStatus()
        {
            if(amt > 0) return bet_money.Bettername + "place bets " + amt + " $ on car no" + car_racer;
            return bet_money.Bettername + " not placed a bet";
        }//THIS CODING IS USED FOR BET MONEY ON EACH CAR//
        public player(cars bet_race)
        {
            bet_money = bet_race;
        }//THIS CODING IS USED FOR SHOW WHON IS WINNER//
        public int Winner(int win)
        {
            if (car_racer == win)
                return amt;
            return -amt;
        }
    }
}
