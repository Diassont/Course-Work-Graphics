namespace Course_Work_Graphics
{
    partial class Rules
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.label1 = new System.Windows.Forms.Label();
            this.ButBackToMenu = new System.Windows.Forms.Button();
            this.ButGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1177, 216);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ButBackToMenu
            // 
            this.ButBackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButBackToMenu.BackgroundImage")));
            this.ButBackToMenu.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButBackToMenu.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ButBackToMenu.Location = new System.Drawing.Point(162, 330);
            this.ButBackToMenu.Name = "ButBackToMenu";
            this.ButBackToMenu.Size = new System.Drawing.Size(325, 60);
            this.ButBackToMenu.TabIndex = 1;
            this.ButBackToMenu.Text = "Повернутися в меню";
            this.ButBackToMenu.UseVisualStyleBackColor = true;
            this.ButBackToMenu.Click += new System.EventHandler(this.ButBackToMenu_Click);
            // 
            // ButGame
            // 
            this.ButGame.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButGame.BackgroundImage")));
            this.ButGame.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ButGame.Location = new System.Drawing.Point(850, 330);
            this.ButGame.Name = "ButGame";
            this.ButGame.Size = new System.Drawing.Size(187, 60);
            this.ButGame.TabIndex = 2;
            this.ButGame.Text = "Грати в гру";
            this.ButGame.UseVisualStyleBackColor = true;
            this.ButGame.Click += new System.EventHandler(this.ButGame_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1201, 411);
            this.ControlBox = false;
            this.Controls.Add(this.ButGame);
            this.Controls.Add(this.ButBackToMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButBackToMenu;
        private System.Windows.Forms.Button ButGame;
    }
}