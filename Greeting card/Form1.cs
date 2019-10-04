using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Greeting_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click (object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen titlePen = new Pen(Color.Brown);
            Font titlefont = new Font("Arial", 30);
            Font titlefont2 = new Font("Palatino Linotype", 30);
            SolidBrush titlebrush = new SolidBrush(Color.Black);
            SolidBrush blueBrush = new SolidBrush(Color.Aqua);
            SolidBrush blueBrush2 = new SolidBrush(Color.Blue);
            SoundPlayer stompSound = new SoundPlayer(Properties.Resources.Grenade);
            SoundPlayer screechSound = new SoundPlayer(Properties.Resources.Godzilla);
            SoundPlayer hornSound = new SoundPlayer(Properties.Resources.Part_Horn);

            g.Clear(Color.Aqua);
            //frame 6
            stompSound.Play();
            g.DrawString("HOPE", titlefont, titlebrush, 100, 120);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 7
            g.DrawString("YOU", titlefont, titlebrush, 230, 120);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 8
            g.DrawString("HAVE", titlefont, titlebrush, 340, 120);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 9
            g.DrawString("AN", titlefont, titlebrush, 470, 120);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 10
            g.DrawString("AMAZING", titlefont, titlebrush, 550, 120);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 11
            g.DrawString("65th!!!", titlefont, titlebrush, 350, 180);
            Thread.Sleep(1000);
            hornSound.Play();

            g.FillRectangle(blueBrush2, 160, 230, 480, 180);
            g.FillRectangle(blueBrush, 170, 240, 460, 160);

            //frame 12
            g.DrawString("CHEERS", titlefont, titlebrush, 170, 290);
            Thread.Sleep(1200);
            hornSound.Play();

            //frame 13
            g.DrawString("FROM", titlefont, titlebrush, 360, 290);
            Thread.Sleep(1200);
            hornSound.Play();

            //frame 14
            g.DrawString("SSES", titlefont, titlebrush, 500, 290);
            Thread.Sleep(1200);
        }

        private void Godzilla2(object sender, EventArgs e)
        { 
            Graphics g = this.CreateGraphics();
            Pen titlePen = new Pen(Color.Brown);
            Font titlefont = new Font("Arial", 30);
            Font titlefont2 = new Font("Palatino Linotype", 15);
            SolidBrush titlebrush = new SolidBrush(Color.Black);
            SolidBrush blueBrush = new SolidBrush(Color.DarkBlue);
            SolidBrush blueBrush2 = new SolidBrush(Color.Black);
            SoundPlayer stompSound = new SoundPlayer(Properties.Resources.Grenade);
            SoundPlayer screechSound = new SoundPlayer(Properties.Resources.Godzilla);

            g.Clear(Color.Aqua);
            g.DrawString("GREETINGS!", titlefont, titlebrush, 205, 60);
            g.DrawString("November 3rd, 2019", titlefont2, titlebrush, 30, 410);
            g.DrawString("Ian Elliott", titlefont2, titlebrush, 640, 410);
            stompSound.Play();
            Thread.Sleep(1000);
            stompSound.Play();

            //frame1
            g.DrawString("AND", titlefont, titlebrush, 465, 60);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 2
            g.DrawString("HAPPY", titlefont, titlebrush, 190, 130);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 3
            g.DrawString("BIRTH", titlefont, titlebrush, 350, 130);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 4
            g.DrawString("DAY", titlefont, titlebrush, 470, 130);
            Thread.Sleep(1000);
            stompSound.Play();

            //frame 5
            g.DrawString("GODZILLA!!!", titlefont, titlebrush, 250, 210);
            Thread.Sleep(1000);
            screechSound.Play();
            Thread.Sleep(6500);
        }

    }
}
        