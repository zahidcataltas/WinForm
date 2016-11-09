using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombies_Nightmare
{

    public partial class Form1 : Form
    {


        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        [DllImport("user32.dll")]
        private static extern IntPtr LoadCursorFromFile(string fileName);
        //public static int fire = 1;
        int zombiAralikSayac = 0;
        int zombiAralik = 30;
        Resim resim = new Resim();
        Zombie zombi1 = new Zombie(10);
        Zombie zombi2 = new Zombie(5);
        Zombie zombi3 = new Zombie(5);
        SoundPlayer sp = new SoundPlayer(Resource1.theme);
        SoundPlayer shoot = new SoundPlayer(Resource1.shoot);



        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            pbSoldier.Parent = pictureBox1;
            pbZombi1.Parent = pictureBox1;
            pbZombi2.Parent = pictureBox1;
            pbZombi3.Parent = pictureBox1;

            //pbZombi2.MouseDown += new MouseEventHandler(pbZombi1_MouseDown);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            zombiAralikSayac++;

            zombi1.zombieFromBirthToDie(pbZombi1, pbSoldier,pbSoldier);

            if (zombiAralikSayac > zombiAralik)
            {

                zombi2.zombieFromBirthToDie(pbZombi2, pbSoldier, pbZombi1);
                this.Cursor = new Cursor("nisan.cur");
            }
            if (zombiAralikSayac > zombiAralik * 2)
            {

                zombi3.zombieFromBirthToDie(pbZombi3, pbSoldier, pbZombi2);
                this.Cursor = new Cursor("nisan.cur");
            }
            if (zombiAralikSayac > zombiAralik * 3)
            {
                
                zombi1.zombieFromBirthToDie(pbZombi1, pbSoldier, pbZombi3);
                this.Cursor = new Cursor("nisan.cur");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mciSendString("close shoot", null, 0, IntPtr.Zero);
            mciSendString(@"open D:\shoot.wav type waveaudio alias shoot", null, 0, IntPtr.Zero);
            mciSendString("play shoot", null, 0, IntPtr.Zero);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("nisan.cur");
            sp.PlayLooping();
        }

        private void pbSoldier_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pbSoldier.Image = Resource1.soldier2;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pbSoldier.Image = Resource1.soldier1;
        }

        private void pbZombi1_MouseDown(object sender, MouseEventArgs e)
        {
            zombi1.fire++;

            pbSoldier.Image = Resource1.soldier2;
            this.Cursor = new Cursor(LoadCursorFromFile("bloody.cur"));


        }

        private void pbZombi1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor("nisan.cur");
            pbSoldier.Image = Resource1.soldier1;
        }

        private void pbZombi1_Click(object sender, EventArgs e)
        {
            mciSendString("close shoot", null, 0, IntPtr.Zero);
            mciSendString(@"open D:\shoot.wav type waveaudio alias shoot", null, 0, IntPtr.Zero);
            mciSendString("play shoot", null, 0, IntPtr.Zero);
        }

        private void pbZombi1_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void pbZombi2_Click(object sender, EventArgs e)
        {
            mciSendString("close shoot", null, 0, IntPtr.Zero);
            mciSendString(@"open D:\shoot.wav type waveaudio alias shoot", null, 0, IntPtr.Zero);
            mciSendString("play shoot", null, 0, IntPtr.Zero);
        }

        private void pbZombi2_MouseDown(object sender, MouseEventArgs e)
        {
            zombi2.fire++;

            pbSoldier.Image = Resource1.soldier2;
            this.Cursor = new Cursor(LoadCursorFromFile("bloody.cur"));
        }

        private void pbZombi2_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor("nisan.cur");
            pbSoldier.Image = Resource1.soldier1;
        }

        private void pbZombi3_Click(object sender, EventArgs e)
        {
            mciSendString("close shoot", null, 0, IntPtr.Zero);
            mciSendString(@"open D:\shoot.wav type waveaudio alias shoot", null, 0, IntPtr.Zero);
            mciSendString("play shoot", null, 0, IntPtr.Zero);
        }

        private void pbZombi3_MouseDown(object sender, MouseEventArgs e)
        {
            zombi3.fire++;

            pbSoldier.Image = Resource1.soldier2;
            this.Cursor = new Cursor(LoadCursorFromFile("bloody.cur"));
        }

        private void pbZombi3_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor("nisan.cur");
            pbSoldier.Image = Resource1.soldier1;
        }
    }
}
