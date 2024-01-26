namespace TestProject
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
            LinesCountTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            FilesCountTextBox = new TextBox();
            label3 = new Label();
            FilePrefixTextBox = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ImportPanel = new Panel();
            StringsImportedLabel = new Label();
            StringsLeftLabel = new Label();
            ImportProgressBar = new ProgressBar();
            SelectFileButton = new Button();
            ImportButton = new Button();
            MergePanel = new Panel();
            FilenameTextBox = new TextBox();
            label4 = new Label();
            RemoveCheckBox = new CheckBox();
            RemoveTextBox = new TextBox();
            MergeProgressBar = new ProgressBar();
            SelectFolderMergeButton = new Button();
            MergeFilesButton = new Button();
            CreatePanel = new Panel();
            FileCreationProgressBar = new ProgressBar();
            SelectFolderButton = new Button();
            CreateButton = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            mergeToolStripMenuItem = new ToolStripMenuItem();
            importToDatabaseToolStripMenuItem = new ToolStripMenuItem();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ImportPanel.SuspendLayout();
            MergePanel.SuspendLayout();
            CreatePanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LinesCountTextBox
            // 
            LinesCountTextBox.Location = new Point(77, 8);
            LinesCountTextBox.Name = "LinesCountTextBox";
            LinesCountTextBox.Size = new Size(115, 23);
            LinesCountTextBox.TabIndex = 2;
            LinesCountTextBox.Text = "100000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Lines count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "Files count";
            // 
            // FilesCountTextBox
            // 
            FilesCountTextBox.Location = new Point(77, 37);
            FilesCountTextBox.Name = "FilesCountTextBox";
            FilesCountTextBox.Size = new Size(115, 23);
            FilesCountTextBox.TabIndex = 4;
            FilesCountTextBox.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "File prefix";
            // 
            // FilePrefixTextBox
            // 
            FilePrefixTextBox.Location = new Point(77, 66);
            FilePrefixTextBox.Name = "FilePrefixTextBox";
            FilePrefixTextBox.Size = new Size(115, 23);
            FilePrefixTextBox.TabIndex = 8;
            FilePrefixTextBox.Text = "File";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ImportPanel);
            tabPage1.Controls.Add(MergePanel);
            tabPage1.Controls.Add(CreatePanel);
            tabPage1.Controls.Add(menuStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "First task";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ImportPanel
            // 
            ImportPanel.Controls.Add(StringsImportedLabel);
            ImportPanel.Controls.Add(StringsLeftLabel);
            ImportPanel.Controls.Add(ImportProgressBar);
            ImportPanel.Controls.Add(SelectFileButton);
            ImportPanel.Controls.Add(ImportButton);
            ImportPanel.Location = new Point(3, 27);
            ImportPanel.Name = "ImportPanel";
            ImportPanel.Size = new Size(368, 168);
            ImportPanel.TabIndex = 15;
            ImportPanel.Visible = false;
            // 
            // StringsImportedLabel
            // 
            StringsImportedLabel.AutoSize = true;
            StringsImportedLabel.Location = new Point(9, 35);
            StringsImportedLabel.Name = "StringsImportedLabel";
            StringsImportedLabel.Size = new Size(107, 15);
            StringsImportedLabel.TabIndex = 17;
            StringsImportedLabel.Tag = "0";
            StringsImportedLabel.Text = "Strings imported: 0";
            // 
            // StringsLeftLabel
            // 
            StringsLeftLabel.AutoSize = true;
            StringsLeftLabel.Location = new Point(10, 10);
            StringsLeftLabel.Name = "StringsLeftLabel";
            StringsLeftLabel.Size = new Size(75, 15);
            StringsLeftLabel.TabIndex = 16;
            StringsLeftLabel.Tag = "0";
            StringsLeftLabel.Text = "Strings left: 0";
            // 
            // ImportProgressBar
            // 
            ImportProgressBar.Location = new Point(10, 53);
            ImportProgressBar.Name = "ImportProgressBar";
            ImportProgressBar.Size = new Size(118, 23);
            ImportProgressBar.TabIndex = 15;
            // 
            // SelectFileButton
            // 
            SelectFileButton.Location = new Point(9, 82);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(58, 23);
            SelectFileButton.TabIndex = 14;
            SelectFileButton.Text = "Select";
            SelectFileButton.UseVisualStyleBackColor = true;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.Location = new Point(73, 82);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(55, 23);
            ImportButton.TabIndex = 13;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // MergePanel
            // 
            MergePanel.Controls.Add(FilenameTextBox);
            MergePanel.Controls.Add(label4);
            MergePanel.Controls.Add(RemoveCheckBox);
            MergePanel.Controls.Add(RemoveTextBox);
            MergePanel.Controls.Add(MergeProgressBar);
            MergePanel.Controls.Add(SelectFolderMergeButton);
            MergePanel.Controls.Add(MergeFilesButton);
            MergePanel.Location = new Point(3, 27);
            MergePanel.Name = "MergePanel";
            MergePanel.Size = new Size(368, 168);
            MergePanel.TabIndex = 14;
            MergePanel.Visible = false;
            // 
            // FilenameTextBox
            // 
            FilenameTextBox.Location = new Point(75, 12);
            FilenameTextBox.Name = "FilenameTextBox";
            FilenameTextBox.Size = new Size(115, 23);
            FilenameTextBox.TabIndex = 18;
            FilenameTextBox.Text = "Merged file";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 15);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 19;
            label4.Text = "Filename";
            // 
            // RemoveCheckBox
            // 
            RemoveCheckBox.AutoSize = true;
            RemoveCheckBox.Location = new Point(14, 41);
            RemoveCheckBox.Name = "RemoveCheckBox";
            RemoveCheckBox.Size = new Size(258, 19);
            RemoveCheckBox.TabIndex = 17;
            RemoveCheckBox.Text = "Remove strimgs that contains this sequence";
            RemoveCheckBox.UseVisualStyleBackColor = true;
            RemoveCheckBox.CheckedChanged += RemoveCheckBox_CheckedChanged;
            // 
            // RemoveTextBox
            // 
            RemoveTextBox.Enabled = false;
            RemoveTextBox.Location = new Point(14, 66);
            RemoveTextBox.Name = "RemoveTextBox";
            RemoveTextBox.Size = new Size(253, 23);
            RemoveTextBox.TabIndex = 16;
            RemoveTextBox.Text = "abc";
            // 
            // MergeProgressBar
            // 
            MergeProgressBar.Location = new Point(14, 95);
            MergeProgressBar.Name = "MergeProgressBar";
            MergeProgressBar.Size = new Size(253, 23);
            MergeProgressBar.TabIndex = 15;
            // 
            // SelectFolderMergeButton
            // 
            SelectFolderMergeButton.Location = new Point(14, 124);
            SelectFolderMergeButton.Name = "SelectFolderMergeButton";
            SelectFolderMergeButton.Size = new Size(130, 23);
            SelectFolderMergeButton.TabIndex = 14;
            SelectFolderMergeButton.Text = "Select I/O folders";
            SelectFolderMergeButton.UseVisualStyleBackColor = true;
            SelectFolderMergeButton.Click += SelectFolderMergeButton_Click;
            // 
            // MergeFilesButton
            // 
            MergeFilesButton.Location = new Point(150, 124);
            MergeFilesButton.Name = "MergeFilesButton";
            MergeFilesButton.Size = new Size(117, 23);
            MergeFilesButton.TabIndex = 13;
            MergeFilesButton.Text = "Merge files";
            MergeFilesButton.UseVisualStyleBackColor = true;
            MergeFilesButton.Click += MergeFilesButton_ClickAsync;
            // 
            // CreatePanel
            // 
            CreatePanel.Controls.Add(FileCreationProgressBar);
            CreatePanel.Controls.Add(SelectFolderButton);
            CreatePanel.Controls.Add(CreateButton);
            CreatePanel.Controls.Add(label1);
            CreatePanel.Controls.Add(FilePrefixTextBox);
            CreatePanel.Controls.Add(LinesCountTextBox);
            CreatePanel.Controls.Add(label2);
            CreatePanel.Controls.Add(FilesCountTextBox);
            CreatePanel.Controls.Add(label3);
            CreatePanel.Location = new Point(3, 27);
            CreatePanel.Name = "CreatePanel";
            CreatePanel.Size = new Size(249, 165);
            CreatePanel.TabIndex = 13;
            CreatePanel.Visible = false;
            // 
            // FileCreationProgressBar
            // 
            FileCreationProgressBar.Location = new Point(5, 95);
            FileCreationProgressBar.Name = "FileCreationProgressBar";
            FileCreationProgressBar.Size = new Size(187, 23);
            FileCreationProgressBar.TabIndex = 12;
            // 
            // SelectFolderButton
            // 
            SelectFolderButton.Location = new Point(3, 124);
            SelectFolderButton.Name = "SelectFolderButton";
            SelectFolderButton.Size = new Size(108, 23);
            SelectFolderButton.TabIndex = 11;
            SelectFolderButton.Text = "Select folder";
            SelectFolderButton.UseVisualStyleBackColor = true;
            SelectFolderButton.Click += SelectFolderButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(117, 124);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(75, 23);
            CreateButton.TabIndex = 10;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(786, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, mergeToolStripMenuItem, importToDatabaseToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(180, 22);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // mergeToolStripMenuItem
            // 
            mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            mergeToolStripMenuItem.Size = new Size(180, 22);
            mergeToolStripMenuItem.Text = "Merge";
            mergeToolStripMenuItem.Click += mergeToolStripMenuItem_Click;
            // 
            // importToDatabaseToolStripMenuItem
            // 
            importToDatabaseToolStripMenuItem.Name = "importToDatabaseToolStripMenuItem";
            importToDatabaseToolStripMenuItem.Size = new Size(180, 22);
            importToDatabaseToolStripMenuItem.Text = "Import to database";
            importToDatabaseToolStripMenuItem.Click += importToDatabaseToolStripMenuItem_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ImportPanel.ResumeLayout(false);
            ImportPanel.PerformLayout();
            MergePanel.ResumeLayout(false);
            MergePanel.PerformLayout();
            CreatePanel.ResumeLayout(false);
            CreatePanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox LinesCountTextBox;
        private Label label1;
        private Label label2;
        private TextBox FilesCountTextBox;
        private Label label3;
        private TextBox FilePrefixTextBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private TabPage tabPage2;
        private Panel CreatePanel;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem mergeToolStripMenuItem;
        private ToolStripMenuItem importToDatabaseToolStripMenuItem;
        private Button CreateButton;
        private Button SelectFolderButton;
        private ProgressBar FileCreationProgressBar;
        private Panel MergePanel;
        private ProgressBar MergeProgressBar;
        private Button SelectFolderMergeButton;
        private Button MergeFilesButton;
        private CheckBox RemoveCheckBox;
        private TextBox RemoveTextBox;
        private TextBox FilenameTextBox;
        private Label label4;
        private Panel ImportPanel;
        private ProgressBar ImportProgressBar;
        private Button SelectFileButton;
        private Button ImportButton;
        private Label StringsImportedLabel;
        private Label StringsLeftLabel;
    }
}
