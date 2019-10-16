using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Packman_Game
{
    public partial class Scene2 : Form
    {
        public Characters.Pacman pacman = null;
        Characters.Enemy enemy = null;

        public Scene2()
        {
            InitializeComponent();
            this.PacmanGroupBox.Controls.Clear();
            this.PacmanGroupBox.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //la réinitialisation devrait réafficher la scéne d origine comment?
            this.PacmanGroupBox.Controls.Clear();
            ucScene11 = new UCScene1();
            this.PacmanGroupBox.Controls.Add(ucScene11);
            if (ucScene11.Controls.OfType<Characters.Pacman>().ToArray().Count() == 0)
            {
                MessageBox.Show("La scéne n'ets pas valide il vous faut un pacman!");
                return;
            }
            pacman = ucScene11.Controls.OfType<Characters.Pacman>().ToArray().First();
            enemy = ucScene11.Controls.OfType<Characters.Enemy>().ToArray().First();
            Characters.Dots[] dots = ucScene11.Controls.OfType<Characters.Dots>().ToArray();
            Characters.Block[] blocks = ucScene11.Controls.OfType<Characters.Block>().ToArray();
            pacman?.Initialize(ref dots, ref blocks);
            enemy?.Initialize(pacman);

            if (pacman != null)
            {
                pacman.Pacman_PointsChanged += new Characters.Pacman_PointsChanged(pack_Pacman_PointsChanged);
                pacman.Pacman_Messages += new Characters.Pacman_Messages(pack_Pacman_Messages);
                pacman.TotalPoints = 0;

            }
        }

    
        void pack_Pacman_Messages(object sender, string messages)
        {
            MessageBox.Show(messages);
            button1_Click(sender, null);
        }

        void pack_Pacman_PointsChanged(object sender, int totalPoints)
        {
            label1.Text = totalPoints.ToString();
        }

        private void Scene2_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"Form1_KeyDown {e.KeyCode}");
            switch (e.KeyCode)
            {
                case Keys.W:
                    pacman?.Move(Characters.MovementWay.Up);
                    break;

                case Keys.S:
                    pacman?.Move(Characters.MovementWay.Down);
                    break;

                case Keys.A:
                    pacman?.Move(Characters.MovementWay.Left);
                    break;

                case Keys.D:
                    pacman?.Move(Characters.MovementWay.Right);
                    break;
            }
        }
    }
}
