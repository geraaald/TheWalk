/*
 * Created by: Gerald Palma
 * Created on: 08-Oct-2015
 * Created for: ICS3U
 * This program displays a walking man.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// for pause
using System.Threading;

namespace TheWalk
{
    public partial class frmTheWalk : Form
    {
        public frmTheWalk()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnWalk_Click(object sender, EventArgs e)
        {
            {
                int loopCounter = 0;

                do
                {
                    if (loopCounter == 0)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk1;
                    }
                    else if (loopCounter == 1)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk2;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 2)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk3;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 3)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk4;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 4)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk5;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 5)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk6;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 6)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk7;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 7)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk8;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 8)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk9;
                        this.picMan.Left = this.picMan.Left - 10;
                    }
                    else if (loopCounter == 9)
                    {
                        this.picMan.Image = TheWalk.Properties.Resources.walk10;
                        this.picMan.Left = this.picMan.Left - 10;
                    }

                    loopCounter = loopCounter + 1;

                    // pause
                    this.Refresh();
                    Thread.Sleep(100);

                } while (loopCounter < 10);
            }

        }
    }
}   
