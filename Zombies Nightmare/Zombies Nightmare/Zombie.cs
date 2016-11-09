using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombies_Nightmare
{
  public  class Zombie
    {
       
       public int solahareket = 1;
       public int born = 0;
        public int zombiGuc;
        public  int fire ;    
        Resim resim = new Resim();
        public Zombie(int guc)
        {
            zombiGuc = guc;
        }      
        public void zombieFromBirthToDie(PictureBox pbzombi, PictureBox pbSoldier, PictureBox lastZombie)
        {
           
            born++;
            resim.ZombieBorn(pbzombi);

            if (born > 8 && !(pbzombi.Location.X < pbSoldier.Location.X + pbSoldier.Width + 1))
            {
                solahareket += 8;
              
                if (lastZombie.Location.X + lastZombie.Width + 1 > pbzombi.Location.X)
                {
                    solahareket -= 8;
                }
                resim.ZombieYuru(pbzombi, 1179 - solahareket);

            }
            if (pbzombi.Location.X == pbSoldier.Location.X + pbSoldier.Width)
            {
                pbzombi.Width = 190;
                resim.ZombieAttack(pbzombi, pbSoldier.Location.X + pbSoldier.Width);
            }
             if (fire >zombiGuc)
            {
                solahareket -= 8;
                resim.ZombieDie(pbzombi, 1179 - solahareket);
               
            }

        }



    }
}
