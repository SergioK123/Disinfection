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
        }

        public new void OnTimerTick(object sender, EventArgs e)
        {

        }

        public new void WasMouseClick(int x, int y)
        {

        }

        ~MenuState()
        {

        }
    }
}
