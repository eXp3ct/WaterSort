using System.Windows.Forms;
namespace WaterSort
{
    partial class Menu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.FristLevel = new System.Windows.Forms.Button();
			this.SecondLevel = new System.Windows.Forms.Button();
			this.ThirsLevel = new System.Windows.Forms.Button();
			this.MenuText = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// FristLevel
			// 
			this.FristLevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.FristLevel.Font = new System.Drawing.Font("Stencil", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FristLevel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FristLevel.Location = new System.Drawing.Point(29, 273);
			this.FristLevel.Name = "FristLevel";
			this.FristLevel.Size = new System.Drawing.Size(191, 165);
			this.FristLevel.TabIndex = 1;
			this.FristLevel.Text = "Level 1";
			this.FristLevel.UseVisualStyleBackColor = true;
			this.FristLevel.Click += new System.EventHandler(this.FristLevel_Click);
			// 
			// SecondLevel
			// 
			this.SecondLevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.SecondLevel.Font = new System.Drawing.Font("Stencil", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SecondLevel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.SecondLevel.Location = new System.Drawing.Point(303, 273);
			this.SecondLevel.Name = "SecondLevel";
			this.SecondLevel.Size = new System.Drawing.Size(191, 165);
			this.SecondLevel.TabIndex = 2;
			this.SecondLevel.Text = "Level 2";
			this.SecondLevel.UseVisualStyleBackColor = true;
			this.SecondLevel.Click += new System.EventHandler(this.SecondLevel_Click);
			// 
			// ThirsLevel
			// 
			this.ThirsLevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ThirsLevel.Font = new System.Drawing.Font("Stencil", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ThirsLevel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ThirsLevel.Location = new System.Drawing.Point(574, 273);
			this.ThirsLevel.Name = "ThirsLevel";
			this.ThirsLevel.Size = new System.Drawing.Size(191, 165);
			this.ThirsLevel.TabIndex = 3;
			this.ThirsLevel.Text = "Level 3";
			this.ThirsLevel.UseVisualStyleBackColor = true;
			this.ThirsLevel.Click += new System.EventHandler(this.ThirsLevel_Click);
			// 
			// MenuText
			// 
			this.MenuText.AutoSize = true;
			this.MenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MenuText.Location = new System.Drawing.Point(218, 115);
			this.MenuText.Name = "MenuText";
			this.MenuText.Size = new System.Drawing.Size(351, 76);
			this.MenuText.TabIndex = 0;
			this.MenuText.Text = "Water Sort";
			this.MenuText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// обАвтореToolStripMenuItem
			// 
			this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
			this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.обАвтореToolStripMenuItem.Text = "Об авторе";
			this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ThirsLevel);
			this.Controls.Add(this.SecondLevel);
			this.Controls.Add(this.FristLevel);
			this.Controls.Add(this.MenuText);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Menu";
			this.Text = "Water Sort";
			this.Load += new System.EventHandler(this.Menu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Button FristLevel;
        private Button SecondLevel;
        private Button ThirsLevel;
        private Label MenuText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem обАвтореToolStripMenuItem;
    }
}

