using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disinfection
{
    public partial class MainForm : Form
    {
        private static State CurrentState;

        public static Timer GlobalTimer;

        public MainForm()
        {
            InitializeComponent();
        }

        public static void ChangeCurrentState(States changeToState)
        {

        }

        public enum States
        {
            menu,
            credits,
            game
        }
    }
}
