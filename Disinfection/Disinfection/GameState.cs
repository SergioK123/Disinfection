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
    public partial class GameState : State
    {
        private List<PictureBox> Monsters;

        private List<Image> MonsterImages;

        private int LeftOffset;//сколько отнять от координат экрана


        public GameState()
        {
            InitializeComponent();
        }

        public new void OnTimerTick(object sender, EventArgs e)
        {

        }

        private void LoadMonsterImages()
        {

        }

        public new void WasMouseClick(int x, int y)
        {

        }

        ~GameState()
        {

        }
    }
}
