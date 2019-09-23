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

            g.Clear(Color. Aqua);
            g.DrawString("GREETINGS!", titlefont, titlebrush, 180, 60);
                
            //frame1
            g.DrawString("AND", titlefont, titlebrush, 440, 60);
            Thread.Sleep(700);
            
            //frame 2
            g.DrawString("HAPPY", titlefont, titlebrush, 200, 130);
            Thread.Sleep(700);
            
            //frame 3
            g.DrawString("BIRTH", titlefont, titlebrush, 360, 130);
            Thread.Sleep(700);
            
            //frame 4
            g.DrawString("DAY", titlefont, titlebrush, 480, 130);
            Thread.Sleep(700);

            //frame 5
            g.DrawString("GODZILLA!!!", titlefont, titlebrush, 250, 190);
            Thread.Sleep(700);

            //frame 6 
            g.DrawString("HOPE", titlefont, titlebrush, 100, 330);
            Thread.Sleep(700);

            //frame 7
            g.DrawString("YOU", titlefont, titlebrush, 230, 330);
            Thread.Sleep(700);

            //frame 8
            g.DrawString("HAVE", titlefont, titlebrush, 340, 330);
            Thread.Sleep(700);

            //frame 9
            g.DrawString("AN", titlefont, titlebrush, 470, 330);
            Thread.Sleep(700);

            //frame 10
            g.DrawString("AMAZING", titlefont, titlebrush, 550, 330);
            Thread.Sleep(700);

            //frame 11
            g.DrawString("65th!!!", titlefont, titlebrush,  350, 380);
            Thread.Sleep(700);


        }
    }
}
