using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Packman_Game.Characters
{
    public delegate void Enemy_Movement(object sender,System.Drawing.Point location);
    public delegate void Enemy_PacmanCatched(object sender);

    public class Enemy : System.Windows.Forms.Control, ICharacter
    {
        public event Enemy_Movement Enemy_Movement;

        Pacman _pacman = null;

        public Enemy()
        {
            this.Height = this.Width = 40;

        }

        public Enemy(Characters.Pacman pacman)
            :this()
        {
            Initialize(pacman);
        }

        public void Initialize(Characters.Pacman pacman)
        {
            _pacman = pacman;
            Enemy_Movement += new Characters.Enemy_Movement(Enemy_Enemy_Movement);
            _pacman.Pacman_Movement += Enemy_Pacman_Movement;
        }

        private void Enemy_Pacman_Movement(object sender, Point location)
        {
            if (location.X > this.Location.X)
                Move(MovementWay.Right);
            else
                Move(MovementWay.Left);

            if (location.Y > this.Location.Y)
                Move(MovementWay.Down);
            else
                Move(MovementWay.Up);
        }

        void Enemy_Enemy_Movement(object sender, System.Drawing.Point location)
        {
            if (_pacman?.Intersect(this) == true)
            {
                _pacman.Catched(this);
            }
        }

        CharacterType m_Type = CharacterType.Enemy;
        public CharacterType Type
        {
            get { return m_Type; }
        }

        public new void Move(MovementWay way)
        {
            switch (way)
            {
                case MovementWay.Up:
                    this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - Speed);
                    break;

                case MovementWay.Down:
                    this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + Speed);
                    break;

                case MovementWay.Left:
                    this.Location = new System.Drawing.Point(this.Location.X - Speed, this.Location.Y);
                    break;

                case MovementWay.Right:
                    this.Location = new System.Drawing.Point(this.Location.X + Speed, this.Location.Y);
                    break;
            }

            Enemy_Movement?.Invoke(this, this.Location);
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            DrawCharacter.Draw(ref e, Type);

            base.OnPaint(e);
        }

        public int TotalPoints
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }

        int m_Speed = 10;
        public int Speed
        {
            get
            {
                return m_Speed;
            }
            set
            {
                m_Speed = value;
            }
        }
    }
}
