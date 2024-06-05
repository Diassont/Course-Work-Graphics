namespace Course_Work_Graphics
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ButRules = new System.Windows.Forms.Button();
            this.ButGame = new System.Windows.Forms.Button();
            this.ButClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButRules
            // 
            this.ButRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButRules.BackgroundImage")));
            this.ButRules.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButRules.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ButRules.Location = new System.Drawing.Point(312, 104);
            this.ButRules.Name = "ButRules";
            this.ButRules.Size = new System.Drawing.Size(190, 60);
            this.ButRules.TabIndex = 0;
            this.ButRules.Text = "Правила";
            this.ButRules.UseVisualStyleBackColor = true;
            this.ButRules.Click += new System.EventHandler(this.ButRules_Click);
            // 
            // ButGame
            // 
            this.ButGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButGame.BackgroundImage")));
            this.ButGame.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButGame.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ButGame.Location = new System.Drawing.Point(312, 213);
            this.ButGame.Name = "ButGame";
            this.ButGame.Size = new System.Drawing.Size(190, 60);
            this.ButGame.TabIndex = 1;
            this.ButGame.Text = "Грати в гру";
            this.ButGame.UseVisualStyleBackColor = true;
            this.ButGame.Click += new System.EventHandler(this.ButGame_Click);
            // 
            // ButClose
            // 
            this.ButClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButClose.BackgroundImage")));
            this.ButClose.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButClose.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.ButClose.Location = new System.Drawing.Point(312, 323);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(190, 60);
            this.ButClose.TabIndex = 2;
            this.ButClose.Text = "Вийти з гри";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.ButClose_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.ControlBox = false;
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButGame);
            this.Controls.Add(this.ButRules);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButRules;
        private System.Windows.Forms.Button ButGame;
        private System.Windows.Forms.Button ButClose;
    }
}