namespace _6월5일_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            열기ToolStripMenuItem = new ToolStripMenuItem();
            저장ToolStripMenuItem = new ToolStripMenuItem();
            편집ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, 편집ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 열기ToolStripMenuItem, 저장ToolStripMenuItem });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(43, 20);
            파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            열기ToolStripMenuItem.Size = new Size(180, 22);
            열기ToolStripMenuItem.Text = "열기";
            // 
            // 저장ToolStripMenuItem
            // 
            저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            저장ToolStripMenuItem.Size = new Size(180, 22);
            저장ToolStripMenuItem.Text = "저장";
            // 
            // 편집ToolStripMenuItem
            // 
            편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            편집ToolStripMenuItem.Size = new Size(43, 20);
            편집ToolStripMenuItem.Text = "편집";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 열기ToolStripMenuItem;
        private ToolStripMenuItem 저장ToolStripMenuItem;
        private ToolStripMenuItem 편집ToolStripMenuItem;
    }
}