using System.Windows.Forms;
namespace WaterSort
{
    partial class ThirdLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdLevel));
            this.Flask1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Flask2 = new System.Windows.Forms.GroupBox();
            this.Flask3 = new System.Windows.Forms.GroupBox();
            this.Flask4 = new System.Windows.Forms.GroupBox();
            this.Flask5 = new System.Windows.Forms.GroupBox();
            this.Flask6 = new System.Windows.Forms.GroupBox();
            this.Flask7 = new System.Windows.Forms.GroupBox();
            this.Flask8 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flask1
            // 
            this.Flask1.BackColor = System.Drawing.SystemColors.Control;
            this.Flask1.Location = new System.Drawing.Point(12, 165);
            this.Flask1.Name = "Flask1";
            this.Flask1.Size = new System.Drawing.Size(63, 273);
            this.Flask1.TabIndex = 0;
            this.Flask1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenu
            // 
            this.StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton});
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(50, 20);
            this.StripMenu.Text = "Game";
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(93, 22);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Flask2
            // 
            this.Flask2.BackColor = System.Drawing.SystemColors.Control;
            this.Flask2.Location = new System.Drawing.Point(109, 165);
            this.Flask2.Name = "Flask2";
            this.Flask2.Size = new System.Drawing.Size(63, 273);
            this.Flask2.TabIndex = 1;
            this.Flask2.TabStop = false;
            // 
            // Flask3
            // 
            this.Flask3.BackColor = System.Drawing.SystemColors.Control;
            this.Flask3.Location = new System.Drawing.Point(211, 165);
            this.Flask3.Name = "Flask3";
            this.Flask3.Size = new System.Drawing.Size(63, 273);
            this.Flask3.TabIndex = 1;
            this.Flask3.TabStop = false;
            // 
            // Flask4
            // 
            this.Flask4.BackColor = System.Drawing.SystemColors.Control;
            this.Flask4.Location = new System.Drawing.Point(307, 165);
            this.Flask4.Name = "Flask4";
            this.Flask4.Size = new System.Drawing.Size(63, 273);
            this.Flask4.TabIndex = 1;
            this.Flask4.TabStop = false;
            // 
            // Flask5
            // 
            this.Flask5.BackColor = System.Drawing.SystemColors.Control;
            this.Flask5.Location = new System.Drawing.Point(404, 165);
            this.Flask5.Name = "Flask5";
            this.Flask5.Size = new System.Drawing.Size(63, 273);
            this.Flask5.TabIndex = 1;
            this.Flask5.TabStop = false;
            // 
            // Flask6
            // 
            this.Flask6.BackColor = System.Drawing.SystemColors.Control;
            this.Flask6.Location = new System.Drawing.Point(509, 165);
            this.Flask6.Name = "Flask6";
            this.Flask6.Size = new System.Drawing.Size(63, 273);
            this.Flask6.TabIndex = 1;
            this.Flask6.TabStop = false;
            // 
            // Flask7
            // 
            this.Flask7.BackColor = System.Drawing.SystemColors.Control;
            this.Flask7.Location = new System.Drawing.Point(628, 165);
            this.Flask7.Name = "Flask7";
            this.Flask7.Size = new System.Drawing.Size(63, 273);
            this.Flask7.TabIndex = 1;
            this.Flask7.TabStop = false;
            // 
            // Flask8
            // 
            this.Flask8.BackColor = System.Drawing.SystemColors.Control;
            this.Flask8.Location = new System.Drawing.Point(725, 165);
            this.Flask8.Name = "Flask8";
            this.Flask8.Size = new System.Drawing.Size(63, 273);
            this.Flask8.TabIndex = 1;
            this.Flask8.TabStop = false;
            // 
            // ThirdLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Flask8);
            this.Controls.Add(this.Flask7);
            this.Controls.Add(this.Flask6);
            this.Controls.Add(this.Flask5);
            this.Controls.Add(this.Flask4);
            this.Controls.Add(this.Flask3);
            this.Controls.Add(this.Flask2);
            this.Controls.Add(this.Flask1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThirdLevel";
            this.Text = "ThirdLevel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FirstLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private GroupBox Flask1;
        private ToolStripMenuItem StripMenu;
        private ToolStripMenuItem ExitButton;
        public MenuStrip menuStrip1;
        private GroupBox Flask2;
        private GroupBox Flask3;
        private GroupBox Flask4;
        private GroupBox Flask5;
        private GroupBox Flask6;
        private GroupBox Flask7;
        private GroupBox Flask8;
    }
}