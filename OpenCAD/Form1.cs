namespace OpenCAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseSourceFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();
            Program.PreSelectSettings.SourceFiles = [];
            lbSourceFiles.Items.Clear();
            foreach (var fileName in ofd.FileNames)
            {
                lbSourceFiles.Items.Add(fileName);
                Program.PreSelectSettings.SourceFiles.Add(fileName);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                string scriptText = textScript.Text;

                string outputFileText = string.Empty;
                bool has = false;
                foreach (var item in lbSourceFiles.Items)
                {
                    string? filePath = item?.ToString();
                    string tmp = $"""
                    open
                    "{filePath}"
                    {scriptText}
                    """;
                    if (has == false)
                    {
                        tmp += "\n";
                        has = true;
                    }
                    outputFileText += tmp;

                }

                File.WriteAllText(txtOutput.Text, outputFileText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
        }

        private void btnBrowseScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.Multiselect = false;
            fileDialog.ShowDialog();
            if (fileDialog.CheckFileExists == false || string.IsNullOrWhiteSpace(fileDialog.FileName))
            {
                MessageBox.Show("Script file doesn't exist");
                return;
            }
            var textScriptFromFile = File.ReadAllText(fileDialog.FileName);
            if (string.IsNullOrWhiteSpace(textScriptFromFile))
            {
                MessageBox.Show("You read a file that only consists of whitespace characters, or is completly empty. Edit directly in text box or read content from other file");
            }
            textScript.Text = textScriptFromFile;
            Program.PreSelectSettings.ScriptText = textScriptFromFile;
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new();
            saveDialog.Filter = "Scr files (*.scr)|*.scr";
            saveDialog.DefaultExt = "scr";
            var dialogResult = saveDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            txtOutput.Text = saveDialog.FileName;
            Program.PreSelectSettings.OutputFilePath = saveDialog.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOutput.Text = Program.PreSelectSettings.OutputFilePath;
            textScript.Text = Program.PreSelectSettings.ScriptText;
            foreach (var sourceFiles in Program.PreSelectSettings.SourceFiles)
            {
                lbSourceFiles.Items.Add(sourceFiles);
            }
        }

        private void textScript_TextChanged(object sender, EventArgs e)
        {
            Program.PreSelectSettings.ScriptText = textScript.Text;
        }
    }
}
