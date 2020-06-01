using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disinfection
{
    public partial class MenuState : State
    {
        public MenuState()
        {
            InitializeComponent();
            //pictureBoxGame.ImageLocation = "";//add path 
            //pictureBoxTitri.ImageLocation = "";//add path 
            //pictureBoxExit.ImageLocation = "";//add path 
        }

        public override void OnTimerTick(object sender, EventArgs e)
        {

        }

        public override void WasMouseClick(int x, int y)
        {

        }

        ~MenuState()
        {

        }

        private void pictureBoxGame_MouseEnter(object sender, EventArgs e)
        {
            //pictureBoxGame.ImageLocation = "";//add path 
        }

        private void pictureBoxGame_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBoxGame.ImageLocation = "";//add path 
            
        }

        private void pictureBoxGame_MouseLeave(object sender, EventArgs e)
        {
            //pictureBoxGame.ImageLocation = "";//add path 
        }

        private void pictureBoxTitri_MouseEnter(object sender, EventArgs e)
        {
            //pictureBoxTitri.ImageLocation = "";//add path 
        }

        private void pictureBoxTitri_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBoxTitri.ImageLocation = "";//add path 
        }

        private void pictureBoxTitri_MouseLeave(object sender, EventArgs e)
        {
            //pictureBoxTitri.ImageLocation = "";//add path 
        }

        private void pictureBoxExit_MouseEnter(object sender, EventArgs e)
        {
            //pictureBoxExit.ImageLocation = "";//add path 
        }

        private void pictureBoxExit_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBoxExit.ImageLocation = "";//add path 
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            //pictureBoxExit.ImageLocation = "";//add path 
        }
    }
}
