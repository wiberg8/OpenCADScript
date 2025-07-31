namespace OpenCAD
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
            btnBrowseSourceFiles = new Button();
            lbSourceFiles = new ListBox();
            textScript = new TextBox();
            createButton = new Button();
            btnBrowseScript = new Button();
            txtOutput = new TextBox();
            label1 = new Label();
            btnOutputBrowse = new Button();
            SuspendLayout();
            // 
            // btnBrowseSourceFiles
            // 
            btnBrowseSourceFiles.Location = new Point(176, 503);
            btnBrowseSourceFiles.Name = "btnBrowseSourceFiles";
            btnBrowseSourceFiles.Size = new Size(75, 23);
            btnBrowseSourceFiles.TabIndex = 0;
            btnBrowseSourceFiles.Text = "Browse";
            btnBrowseSourceFiles.UseVisualStyleBackColor = true;
            btnBrowseSourceFiles.Click += btnBrowseSourceFiles_Click;
            // 
            // lbSourceFiles
            // 
            lbSourceFiles.FormattingEnabled = true;
            lbSourceFiles.ItemHeight = 15;
            lbSourceFiles.Location = new Point(12, 88);
            lbSourceFiles.Name = "lbSourceFiles";
            lbSourceFiles.Size = new Size(239, 409);
            lbSourceFiles.TabIndex = 1;
            // 
            // textScript
            // 
            textScript.Location = new Point(257, 88);
            textScript.Multiline = true;
            textScript.Name = "textScript";
            textScript.Size = new Size(524, 409);
            textScript.TabIndex = 2;
            textScript.TextChanged += textScript_TextChanged;
            // 
            // createButton
            // 
            createButton.Location = new Point(675, 503);
            createButton.Name = "createButton";
            createButton.Size = new Size(106, 23);
            createButton.TabIndex = 3;
            createButton.Text = "Create output";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // btnBrowseScript
            // 
            btnBrowseScript.Location = new Point(257, 503);
            btnBrowseScript.Name = "btnBrowseScript";
            btnBrowseScript.Size = new Size(75, 23);
            btnBrowseScript.TabIndex = 4;
            btnBrowseScript.Text = "Browse";
            btnBrowseScript.UseVisualStyleBackColor = true;
            btnBrowseScript.Click += btnBrowseScript_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 30);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(769, 23);
            txtOutput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 6;
            label1.Text = "Output filepath";
            // 
            // btnOutputBrowse
            // 
            btnOutputBrowse.Location = new Point(706, 59);
            btnOutputBrowse.Name = "btnOutputBrowse";
            btnOutputBrowse.Size = new Size(75, 23);
            btnOutputBrowse.TabIndex = 7;
            btnOutputBrowse.Text = "Browse";
            btnOutputBrowse.UseVisualStyleBackColor = true;
            btnOutputBrowse.Click += btnOutputBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 534);
            Controls.Add(btnOutputBrowse);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(btnBrowseScript);
            Controls.Add(createButton);
            Controls.Add(textScript);
            Controls.Add(lbSourceFiles);
            Controls.Add(btnBrowseSourceFiles);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseSourceFiles;
        private ListBox lbSourceFiles;
        private TextBox textScript;
        private Button createButton;
        private Button btnBrowseScript;
        private TextBox txtOutput;
        private Label label1;
        private Button btnOutputBrowse;
    }
}
