namespace TicTacToe
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoStartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xStartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oStartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameButton0 = new System.Windows.Forms.Button();
            this.gameButton2 = new System.Windows.Forms.Button();
            this.gameButton1 = new System.Windows.Forms.Button();
            this.gameButton4 = new System.Windows.Forms.Button();
            this.gameButton5 = new System.Windows.Forms.Button();
            this.gameButton3 = new System.Windows.Forms.Button();
            this.gameButton7 = new System.Windows.Forms.Button();
            this.gameButton8 = new System.Windows.Forms.Button();
            this.gameButton6 = new System.Windows.Forms.Button();
            this.InformationBox = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsAIToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            resources.ApplyResources(this.newGameToolStripMenuItem, "newGameToolStripMenuItem");
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            resources.ApplyResources(this.playerVsPlayerToolStripMenuItem, "playerVsPlayerToolStripMenuItem");
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.playerVsPlayerToolStripMenuItem_Click);
            // 
            // playerVsAIToolStripMenuItem
            // 
            this.playerVsAIToolStripMenuItem.Name = "playerVsAIToolStripMenuItem";
            resources.ApplyResources(this.playerVsAIToolStripMenuItem, "playerVsAIToolStripMenuItem");
            this.playerVsAIToolStripMenuItem.Click += new System.EventHandler(this.playerVsAIToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoStartsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // whoStartsToolStripMenuItem
            // 
            this.whoStartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomToolStripMenuItem,
            this.xStartsToolStripMenuItem,
            this.oStartsToolStripMenuItem});
            this.whoStartsToolStripMenuItem.Name = "whoStartsToolStripMenuItem";
            resources.ApplyResources(this.whoStartsToolStripMenuItem, "whoStartsToolStripMenuItem");
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            resources.ApplyResources(this.randomToolStripMenuItem, "randomToolStripMenuItem");
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // xStartsToolStripMenuItem
            // 
            this.xStartsToolStripMenuItem.Name = "xStartsToolStripMenuItem";
            resources.ApplyResources(this.xStartsToolStripMenuItem, "xStartsToolStripMenuItem");
            this.xStartsToolStripMenuItem.Click += new System.EventHandler(this.xStartsToolStripMenuItem_Click);
            // 
            // oStartsToolStripMenuItem
            // 
            this.oStartsToolStripMenuItem.Name = "oStartsToolStripMenuItem";
            resources.ApplyResources(this.oStartsToolStripMenuItem, "oStartsToolStripMenuItem");
            this.oStartsToolStripMenuItem.Click += new System.EventHandler(this.oStartsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gameButton0
            // 
            resources.ApplyResources(this.gameButton0, "gameButton0");
            this.gameButton0.Name = "gameButton0";
            this.gameButton0.UseVisualStyleBackColor = true;
            this.gameButton0.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton2
            // 
            resources.ApplyResources(this.gameButton2, "gameButton2");
            this.gameButton2.Name = "gameButton2";
            this.gameButton2.UseVisualStyleBackColor = true;
            this.gameButton2.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton1
            // 
            resources.ApplyResources(this.gameButton1, "gameButton1");
            this.gameButton1.Name = "gameButton1";
            this.gameButton1.UseVisualStyleBackColor = true;
            this.gameButton1.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton4
            // 
            resources.ApplyResources(this.gameButton4, "gameButton4");
            this.gameButton4.Name = "gameButton4";
            this.gameButton4.UseVisualStyleBackColor = true;
            this.gameButton4.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton5
            // 
            resources.ApplyResources(this.gameButton5, "gameButton5");
            this.gameButton5.Name = "gameButton5";
            this.gameButton5.UseVisualStyleBackColor = true;
            this.gameButton5.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton3
            // 
            resources.ApplyResources(this.gameButton3, "gameButton3");
            this.gameButton3.Name = "gameButton3";
            this.gameButton3.UseVisualStyleBackColor = true;
            this.gameButton3.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton7
            // 
            resources.ApplyResources(this.gameButton7, "gameButton7");
            this.gameButton7.Name = "gameButton7";
            this.gameButton7.UseVisualStyleBackColor = true;
            this.gameButton7.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton8
            // 
            resources.ApplyResources(this.gameButton8, "gameButton8");
            this.gameButton8.Name = "gameButton8";
            this.gameButton8.UseVisualStyleBackColor = true;
            this.gameButton8.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // gameButton6
            // 
            resources.ApplyResources(this.gameButton6, "gameButton6");
            this.gameButton6.Name = "gameButton6";
            this.gameButton6.UseVisualStyleBackColor = true;
            this.gameButton6.Click += new System.EventHandler(this.gameButtonClick);
            // 
            // InformationBox
            // 
            this.InformationBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.InformationBox, "InformationBox");
            this.InformationBox.Name = "InformationBox";
            this.InformationBox.ReadOnly = true;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.Reset, "Reset");
            this.Reset.Name = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // TicTacToe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.InformationBox);
            this.Controls.Add(this.gameButton7);
            this.Controls.Add(this.gameButton8);
            this.Controls.Add(this.gameButton6);
            this.Controls.Add(this.gameButton4);
            this.Controls.Add(this.gameButton5);
            this.Controls.Add(this.gameButton3);
            this.Controls.Add(this.gameButton1);
            this.Controls.Add(this.gameButton2);
            this.Controls.Add(this.gameButton0);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoStartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xStartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oStartsToolStripMenuItem;
        private System.Windows.Forms.Button gameButton0;
        private System.Windows.Forms.Button gameButton2;
        private System.Windows.Forms.Button gameButton1;
        private System.Windows.Forms.Button gameButton4;
        private System.Windows.Forms.Button gameButton5;
        private System.Windows.Forms.Button gameButton3;
        private System.Windows.Forms.Button gameButton7;
        private System.Windows.Forms.Button gameButton8;
        private System.Windows.Forms.Button gameButton6;
        private System.Windows.Forms.TextBox InformationBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

