namespace FLA_6___Notepad
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuNew = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            menuUndo = new ToolStripMenuItem();
            menuRedo = new ToolStripMenuItem();
            menuCut = new ToolStripMenuItem();
            menuCopy = new ToolStripMenuItem();
            menuPaste = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            menuFont = new ToolStripMenuItem();
            menuColor = new ToolStripMenuItem();
            menuWordCount = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, menuWordCount });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(753, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNew, menuOpen, menuSave, menuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuNew
            // 
            menuNew.Name = "menuNew";
            menuNew.Size = new Size(103, 22);
            menuNew.Text = "New";
            menuNew.Click += menuNew_Click;
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(103, 22);
            menuOpen.Text = "Open";
            menuOpen.Click += menuOpen_Click;
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(103, 22);
            menuSave.Text = "Save";
            menuSave.Click += menuSave_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(103, 22);
            menuExit.Text = "Exit";
            menuExit.Click += menuExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuUndo, menuRedo, menuCut, menuCopy, menuPaste });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // menuUndo
            // 
            menuUndo.Name = "menuUndo";
            menuUndo.Size = new Size(103, 22);
            menuUndo.Text = "Undo";
            menuUndo.Click += menuUndo_Click;
            // 
            // menuRedo
            // 
            menuRedo.Name = "menuRedo";
            menuRedo.Size = new Size(103, 22);
            menuRedo.Text = "Redo";
            menuRedo.Click += menuRedo_Click;
            // 
            // menuCut
            // 
            menuCut.Name = "menuCut";
            menuCut.Size = new Size(103, 22);
            menuCut.Text = "Cut";
            menuCut.Click += menuCut_Click;
            // 
            // menuCopy
            // 
            menuCopy.Name = "menuCopy";
            menuCopy.Size = new Size(103, 22);
            menuCopy.Text = "Copy";
            menuCopy.Click += menuCopy_Click;
            // 
            // menuPaste
            // 
            menuPaste.Name = "menuPaste";
            menuPaste.Size = new Size(103, 22);
            menuPaste.Text = "Paste";
            menuPaste.Click += menuPaste_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuFont, menuColor });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // menuFont
            // 
            menuFont.Name = "menuFont";
            menuFont.Size = new Size(103, 22);
            menuFont.Text = "Font";
            menuFont.Click += menuFont_Click;
            // 
            // menuColor
            // 
            menuColor.Name = "menuColor";
            menuColor.Size = new Size(103, 22);
            menuColor.Text = "Color";
            menuColor.Click += menuColor_Click;
            // 
            // menuWordCount
            // 
            menuWordCount.Name = "menuWordCount";
            menuWordCount.Size = new Size(84, 20);
            menuWordCount.Text = "Word Count";
            menuWordCount.Click += menuWordCount_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(753, 354);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 378);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuNew;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuUndo;
        private ToolStripMenuItem menuRedo;
        private ToolStripMenuItem menuCut;
        private ToolStripMenuItem menuCopy;
        private ToolStripMenuItem menuPaste;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem menuFont;
        private ToolStripMenuItem menuColor;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem menuWordCount;
    }
}