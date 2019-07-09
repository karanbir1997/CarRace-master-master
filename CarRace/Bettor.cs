using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public class Bettor// THIS CODING IS USED FOR START SYSTEM//
    {
        public PictureBox carPicturebox;
        public int Startpos;
        public Random rad;
        public int start_race;
        public int Fullrace;
      

        public bool First_Race()
        {
            Startpos = rad.Next(5);
            carPicturebox.Left += start_race + Startpos;

            if (carPicturebox.Left >= Fullrace)
                return true;

            return false;
        }
        public void startPosi()
        {
            this.carPicturebox.Left = 0;
            this.Startpos = 0;
        }

       
    }
}
