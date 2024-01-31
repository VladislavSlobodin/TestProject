using System.Text;

namespace TestProject;

public partial class Form1 : Form
{
    private string _inputDirectory = null!;
    private string _outputDirectory = null!;
    private string _baseName = null!;
    private string _filename = null!;
    private readonly string _extension = ".txt";
    private readonly int PACKAGE_SIZE = 1000;

    public Form1()
    {
        InitializeComponent();
    }

    private void ShowError(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

    private void ShowPanel(Panel panel)
    {
        tabPage1.Hide<Panel>();
        panel.Show();
    }

    private void createToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowPanel(CreatePanel);
    }

    private void SelectFolderButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog dialog = new();
        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        _inputDirectory = dialog.SelectedPath;
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(LinesCountTextBox.Text, out var linesCount) || linesCount <= 0 ||
            !int.TryParse(FilesCountTextBox.Text, out var filesCount) || filesCount <= 0 ||
            FilePrefixTextBox.Text.Trim().Length == 0)
        {
            ShowError("Incorrect data entered.");
            return;
        }

        _baseName = FilePrefixTextBox.Text.Trim();
        FileCreationProgressBar.Value = 0;
        FileCreationProgressBar.Maximum = filesCount;
        for (int id = 1; id <= filesCount; id++)
        {
            var path = $@"{_inputDirectory}\{_baseName}{id}{_extension}";
            var lines = Enumerable.Range(0, linesCount).Select(x => StringFactory.Create());
            File.WriteAllLines(path, lines);
            FileCreationProgressBar.Value++;
        }
    }

    private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowPanel(MergePanel);
    }

    private void SelectFolderMergeButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog dialog = new();
        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        _inputDirectory = dialog.SelectedPath;
        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        _outputDirectory = dialog.SelectedPath;
    }

    private async void MergeFilesButton_ClickAsync(object sender, EventArgs e)
    {
        var files = Directory.GetFiles(_inputDirectory);
        if (files.Length == 0)
        {
            ShowError("There are no files in the folder.");
            return;
        }

        MergeProgressBar.Value = 0;
        MergeProgressBar.Maximum = files.Length;
        var path = $@"{_outputDirectory}{FilenameTextBox.Text.Trim()}{_extension}";
        int linesRemoved = await WriteFilesAsync(path, files, RemoveCheckBox.Checked);

        MessageBox.Show($"""
        Files successfully merged.
        {(RemoveCheckBox.Checked ? $"Removed {linesRemoved} line{(linesRemoved != 1 ? "s" : string.Empty)}." : string.Empty)}
        """);
    }

    private async Task<int> WriteFilesAsync(string path, string[] files, bool isRemoving = false)
    {
        var linesRemoved = 0;
        foreach (var file in files)
        {
            if (!File.Exists(file))
            {
                continue;
            }

            linesRemoved += await WriteFileAsync(path, file, isRemoving);
            MergeProgressBar.Value++;
        }

        return linesRemoved;
    }

    private async Task<int> WriteFileAsync(string path, string file, bool isRemoving = false)
    {
        var lines = await File.ReadAllLinesAsync(file);
        var linesBefore = lines.Length;
        var forbiddenCombination = RemoveTextBox.Text.Trim();
        lines = isRemoving ? lines.Where(l => !l.Contains(forbiddenCombination)).ToArray() : lines;
        await File.AppendAllLinesAsync(path, lines);
        return linesBefore - lines.Length;
    }

    private void RemoveCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        RemoveTextBox.Enabled = RemoveCheckBox.Checked;
    }

    private void importToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowPanel(ImportPanel);
    }

    private void SelectFileButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new();
        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            ShowError("Unable to open file");
            return;
        }

        _filename = openFileDialog.FileName;
    }

    private async void ImportButton_Click(object sender, EventArgs e)
    {
        var linesCount = File.ReadAllLines(_filename).Count();
        StringsLeftLabel.Tag = linesCount;
        ImportProgressBar.Value = 0;
        ImportProgressBar.Maximum = linesCount / PACKAGE_SIZE;
        using StreamReader reader = new(_filename);
        while (!reader.EndOfStream)
        {
            var entities = await MakePackage(reader);
            var rowsAdded = await AddToDatabase(entities);
            UpdateLabels(rowsAdded);
            ImportProgressBar.Value++;
        }
    }

    private async Task<List<string>> MakePackage(StreamReader reader)
    {
        List<string> entities = [];
        while (entities.Count < PACKAGE_SIZE && !reader.EndOfStream)
        {
            var line = await reader.ReadLineAsync();
            var entity = TransformToSQLData(line!);
            entities.Add(entity);
        }

        return entities;
    }

    private string TransformToSQLData(string line)
    {
        var data = line.Split("||");
        return $"('{data[0]}', '{data[1]}', N'{data[2]}', '{data[3]}', '{data[4]}')";
    }

    private async Task<int> AddToDatabase(List<string> entities) => await DatabaseManager.WriteAsync(entities);

    private void UpdateLabels(int count)
    {
        StringsLeftLabel.Tag = Convert.ToInt32(StringsLeftLabel.Tag) - count;
        StringsLeftLabel.Text = $"Strings left: {StringsLeftLabel.Tag}";
        StringsImportedLabel.Tag = Convert.ToInt32(StringsImportedLabel.Tag) + count;
        StringsImportedLabel.Text = $"Strings imported: {StringsImportedLabel.Tag}";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        BalanceUnit balanceUnit = new()
        {
            Id = 1,
            AccountId = 1,
            BalanceType = BalanceType.ActiveOpeningBalance,
            ClassId = 1,
            Value = 1
        };

        using ExcelDbContext context = new();
        context.BalanceUnits.Add(balanceUnit);
        context.SaveChanges();

        MessageBox.Show(context.BalanceUnits.Count().ToString());
    }
}