using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombies_Nightmare
{
    class Resim
    {

        int hareket = 0;
        int die = -1;
       
        public void ZombieBorn(PictureBox pb)
        {
            hareket++;
            Image zombi = Resource1.go_1; ;

            if (hareket % 9 == 0) zombi = Resource1.appear_1;
            else if (hareket % 9 == 1) zombi = Resource1.appear_2;
            else if (hareket % 9 == 2) zombi = Resource1.appear_3;
            else if (hareket % 9 == 3) zombi = Resource1.appear_4;
            else if (hareket % 9 == 4) zombi = Resource1.appear_5;
            else if (hareket % 9 == 5) zombi = Resource1.appear_6;
            else if (hareket % 9 == 6) zombi = Resource1.appear_7;
            else if (hareket % 9 == 7) zombi = Resource1.appear_8;
            else if (hareket % 9 == 8) zombi = Resource1.appear_9;
            else if (hareket % 9 == 0)
            {
                zombi = Resource1.appear_10;
            }
            pb.Image = zombi;
        }

        public void ZombieYuru(PictureBox pb, int x)
        {
            hareket++;
            Image zombi = Resource1.go_1; ;

            if (hareket % 9 == 0) zombi = Resource1.go_9;
            else if (hareket % 9 == 1) zombi = Resource1.go_1;
            else if (hareket % 9 == 2) zombi = Resource1.go_2;
            else if (hareket % 9 == 3) zombi = Resource1.go_3;
            else if (hareket % 9 == 4) zombi = Resource1.go_4;
            else if (hareket % 9 == 5) zombi = Resource1.go_5;
            else if (hareket % 9 == 6) zombi = Resource1.go_6;
            else if (hareket % 9 == 7) zombi = Resource1.go_7;
            else if (hareket % 9 == 8) zombi = Resource1.go_8;
            pb.Location = new Point(x, 369);
            pb.Image = zombi;

        }
        public void ZombieAttack(PictureBox pb, int x)
        {
            hareket++;
            Image zombi = Resource1.hit_1;


            if (hareket % 7 == 0) zombi = Resource1.hit_1;
            else if (hareket % 7 == 1) zombi = Resource1.hit_2;
            else if (hareket % 7 == 2) zombi = Resource1.hit_3;
            else if (hareket % 7 == 3) zombi = Resource1.hit_4;
            else if (hareket % 7 == 4) zombi = Resource1.hit_5;
            else if (hareket % 7 == 5) zombi = Resource1.hit_6;
            else if (hareket % 7 == 6) zombi = Resource1.hit_7;

            pb.Location = new Point(x, 369);
            pb.Image = zombi;
        }
        public void ZombieDie(PictureBox pb, int x)
        {
            die++;
            Image zombi = Resource1.die_1;


            if (die == 0) zombi = Resource1.die_1;
            else if (die == 1) zombi = Resource1.die_2;
            else if (die == 2) zombi = Resource1.die_3;
            else if (die == 3) zombi = Resource1.die_4;
            else if (die == 4) zombi = Resource1.die_5;
            else if (die == 5) zombi = Resource1.die_6;
            else if (die == 6) zombi = Resource1.die_7;
            else if (die == 7) zombi = Resource1.die_8;
            else if (hareket > 7)
            {
                pb.Hide();
                pb.Location = new Point(0, 0);
               
            }

            pb.Image = zombi;


        }



    }
}
