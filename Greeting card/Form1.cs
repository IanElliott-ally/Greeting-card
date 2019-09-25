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

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen titlePen = new Pen(Color.Brown);
            Font titlefont = new Font("Arial", 30);
            SolidBrush titlebrush = new SolidBrush(Color.Black);
            SolidBrush borderBrush = new SolidBrush(Color.DarkBlue);
            SolidBrush borderBrush1 = new SolidBrush(Color.Black);
            SoundPlayer Stomp = new SoundPlayer(Properties.Resources.Grenade);
            SoundPlayer Screee = new SoundPlayer(Properties.Resources.Godzilla);

            g.Clear(Color.Aqua);
            g.DrawString("GREETINGS!", titlefont, titlebrush, 205, 60);
            Stomp.Play();
            Thread.Sleep(1000);
            Stomp.Play();

            //frame1
            g.DrawString("AND", titlefont, titlebrush, 465, 60);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 2
            g.DrawString("HAPPY", titlefont, titlebrush, 190, 130);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 3
            g.DrawString("BIRTH", titlefont, titlebrush, 350, 130);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 4
            g.DrawString("DAY", titlefont, titlebrush, 470, 130);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 5
            g.DrawString("GODZILLA!!!", titlefont, titlebrush, 250, 210);
            Thread.Sleep(1000);
            Screee.Play();
            Thread.Sleep(6500);




        }

        private void Form1_Click(object sender, EventArgs e)
            
        { Graphics g = this.CreateGraphics();
            Pen titlePen = new Pen(Color.Brown);
            Font titlefont = new Font("Arial", 30);
            SolidBrush titlebrush = new SolidBrush(Color.Black);
            SolidBrush borderBrush = new SolidBrush(Color.LightBlue);
            SolidBrush borderBrush1 = new SolidBrush(Color.Blue);
            SoundPlayer Stomp = new SoundPlayer(Properties.Resources.Grenade);
            SoundPlayer Screee = new SoundPlayer(Properties.Resources.Godzilla);
            SoundPlayer Horn = new SoundPlayer(Properties.Resources.Part_Horn);
        

            g.Clear(Color.Aqua);
            //frame 6
            g.DrawString("HOPE", titlefont, titlebrush, 100, 120);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 7
            g.DrawString("YOU", titlefont, titlebrush, 230, 120);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 8
            g.DrawString("HAVE", titlefont, titlebrush, 340, 120);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 9
            g.DrawString("AN", titlefont, titlebrush, 470, 120);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 10
            g.DrawString("AMAZING", titlefont, titlebrush, 550, 120);
            Thread.Sleep(1000);
            Stomp.Play();

            //frame 11
            g.DrawString("65th!!!", titlefont, titlebrush, 350, 180);
            Thread.Sleep(1000);
            Horn.Play();

            g.FillRectangle(borderBrush1, 130, 190, 500, 200);
            g.FillRectangle(borderBrush, 140, 180, 500, 200);

            //frame 12
            g.DrawString("CHEERS", titlefont, titlebrush, 150, 290);
            Thread.Sleep(1000);
            Horn.Play();

            //frame 13
            g.DrawString("FROM", titlefont, titlebrush, 340, 290);
            Thread.Sleep(1000);
            Horn.Play();

            //frame 14
            g.DrawString("SSES", titlefont, titlebrush, 490, 290);
            Thread.Sleep(1000);
            
            
        }
    }
}
