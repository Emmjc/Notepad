namespace FLA_6___Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            // Ask the user if they are sure to create a new file
            DialogResult result = MessageBox.Show("Are you sure you want to create a new file?", "New File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Open a new file
                richTextBox1.Clear();
            }
            // If the user selects 'No', do nothing
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Load the file
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);

                // Change the form title to the opened file's name if it's a .txt file
                if (Path.GetExtension(ofd.FileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    this.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                }
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Save the file
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                // Change the form title to the saved file's name
                this.Text = Path.GetFileNameWithoutExtension(sfd.FileName);
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void menuRedo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog.Font;
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog.Color;
        }
        // Method to calculate word count
        private int GetWordCount()
        {
            // Word count is the total number of words separated by space
            return richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void menuWordCount_Click(object sender, EventArgs e)
        {
            // Get word count, character count, and paragraph count
            int wordCount = GetWordCount();
            int characterCount = richTextBox1.Text.Length;

            // Display the information in a MessageBox
            MessageBox.Show(
                $"Word Count: {wordCount}\n" +
                $"Character Count: {characterCount}\n",
                "Word Count Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}