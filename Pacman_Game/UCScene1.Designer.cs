namespace Packman_Game
{
    partial class UCScene1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.enemy1 = new Packman_Game.Characters.Enemy();
            this.dots3 = new Packman_Game.Characters.Dots();
            this.dots2 = new Packman_Game.Characters.Dots();
            this.dots1 = new Packman_Game.Characters.Dots();
            this.block2 = new Packman_Game.Characters.Block();
            this.block1 = new Packman_Game.Characters.Block();
            this.pacman1 = new Packman_Game.Characters.Pacman();
            this.dots4 = new Packman_Game.Characters.Dots();
            this.dots5 = new Packman_Game.Characters.Dots();
            this.SuspendLayout();
            // 
            // enemy1
            // 
            this.enemy1.Location = new System.Drawing.Point(622, 152);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(40, 40);
            this.enemy1.Speed = 10;
            this.enemy1.TabIndex = 5;
            this.enemy1.Text = "enemy1";
            this.enemy1.TotalPoints = 0;
            // 
            // dots3
            // 
            this.dots3.Dot_Color = System.Drawing.Color.Yellow;
            this.dots3.Location = new System.Drawing.Point(106, 333);
            this.dots3.Name = "dots3";
            this.dots3.Size = new System.Drawing.Size(30, 30);
            this.dots3.TabIndex = 4;
            this.dots3.Text = "dots3";
            // 
            // dots2
            // 
            this.dots2.Dot_Color = System.Drawing.Color.Yellow;
            this.dots2.Location = new System.Drawing.Point(106, 210);
            this.dots2.Name = "dots2";
            this.dots2.Size = new System.Drawing.Size(30, 30);
            this.dots2.TabIndex = 3;
            this.dots2.Text = "dots2";
            // 
            // dots1
            // 
            this.dots1.Dot_Color = System.Drawing.Color.Yellow;
            this.dots1.Location = new System.Drawing.Point(107, 126);
            this.dots1.Name = "dots1";
            this.dots1.Size = new System.Drawing.Size(30, 30);
            this.dots1.TabIndex = 2;
            this.dots1.Text = "dots1";
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Brown;
            this.block2.Block_Color = System.Drawing.Color.Brown;
            this.block2.Location = new System.Drawing.Point(405, 126);
            this.block2.Name = "block2";
            this.block2.Orientation = Packman_Game.Characters.Block.MyOrientation.vertical;
            this.block2.Size = new System.Drawing.Size(23, 420);
            this.block2.TabIndex = 1;
            this.block2.Text = "block2";
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Brown;
            this.block1.Block_Color = System.Drawing.Color.Brown;
            this.block1.Location = new System.Drawing.Point(198, 75);
            this.block1.Name = "block1";
            this.block1.Orientation = Packman_Game.Characters.Block.MyOrientation.horizontal;
            this.block1.Size = new System.Drawing.Size(594, 23);
            this.block1.TabIndex = 0;
            this.block1.Text = "block1";
            // 
            // pacman1
            // 
            this.pacman1.Location = new System.Drawing.Point(738, 438);
            this.pacman1.Name = "pacman1";
            this.pacman1.Size = new System.Drawing.Size(40, 40);
            this.pacman1.Speed = 20;
            this.pacman1.TabIndex = 6;
            this.pacman1.Text = "pacman1";
            this.pacman1.TotalPoints = 0;
            // 
            // dots4
            // 
            this.dots4.Dot_Color = System.Drawing.Color.Yellow;
            this.dots4.Location = new System.Drawing.Point(494, 251);
            this.dots4.Name = "dots4";
            this.dots4.Size = new System.Drawing.Size(30, 30);
            this.dots4.TabIndex = 7;
            this.dots4.Text = "dots4";
            // 
            // dots5
            // 
            this.dots5.Dot_Color = System.Drawing.Color.Yellow;
            this.dots5.Location = new System.Drawing.Point(494, 315);
            this.dots5.Name = "dots5";
            this.dots5.Size = new System.Drawing.Size(30, 30);
            this.dots5.TabIndex = 8;
            this.dots5.Text = "dots5";
            // 
            // UCScene1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dots5);
            this.Controls.Add(this.dots4);
            this.Controls.Add(this.pacman1);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.dots3);
            this.Controls.Add(this.dots2);
            this.Controls.Add(this.dots1);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block1);
            this.Name = "UCScene1";
            this.Size = new System.Drawing.Size(809, 614);
            this.ResumeLayout(false);

        }

        #endregion

        private Characters.Block block1;
        private Characters.Block block2;
        private Characters.Dots dots1;
        private Characters.Dots dots2;
        private Characters.Dots dots3;
        private Characters.Enemy enemy1;
        private Characters.Pacman pacman1;
        private Characters.Dots dots4;
        private Characters.Dots dots5;
    }
}
