namespace Disinfection
{
    partial class MenuState
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureFon = new System.Windows.Forms.PictureBox();
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitri = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFon
            // 
            this.pictureFon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureFon.Location = new System.Drawing.Point(0, 0);
            this.pictureFon.Name = "pictureFon";
            this.pictureFon.Size = new System.Drawing.Size(1181, 494);
            this.pictureFon.TabIndex = 0;
            this.pictureFon.TabStop = false;
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.Location = new System.Drawing.Point(454, 145);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(202, 58);
            this.pictureBoxGame.TabIndex = 1;
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGame_MouseClick);
            this.pictureBoxGame.MouseEnter += new System.EventHandler(this.pictureBoxGame_MouseEnter);
            this.pictureBoxGame.MouseLeave += new System.EventHandler(this.pictureBoxGame_MouseLeave);
            // 
            // pictureBoxTitri
            // 
            this.pictureBoxTitri.Location = new System.Drawing.Point(454, 222);
            this.pictureBoxTitri.Name = "pictureBoxTitri";
            this.pictureBoxTitri.Size = new System.Drawing.Size(202, 58);
            this.pictureBoxTitri.TabIndex = 2;
            this.pictureBoxTitri.TabStop = false;
            this.pictureBoxTitri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTitri_MouseClick);
            this.pictureBoxTitri.MouseEnter += new System.EventHandler(this.pictureBoxTitri_MouseEnter);
            this.pictureBoxTitri.MouseLeave += new System.EventHandler(this.pictureBoxTitri_MouseLeave);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Location = new System.Drawing.Point(454, 302);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(202, 58);
            this.pictureBoxExit.TabIndex = 3;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxExit_MouseClick);
            this.pictureBoxExit.MouseEnter += new System.EventHandler(this.pictureBoxExit_MouseEnter);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            // 
            // MenuState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxTitri);
            this.Controls.Add(this.pictureBoxGame);
            this.Controls.Add(this.pictureFon);
            this.Name = "MenuState";
            this.Size = new System.Drawing.Size(1181, 494);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFon;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.PictureBox pictureBoxTitri;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}
