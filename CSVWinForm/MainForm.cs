
using CSVLibrary;
using System.Data;

namespace CSVWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            ComboBoxSeperator.DataSource = new List<string>() { ",", ";", ":", "|", " " };
            AddColumn.Hide();
            SpacesBox.Hide();
            SpacesText.Hide();
            SaveCSV.Hide();
        }
        private CSVFunctions _csvFunctions = new CSVFunctions();
        private DataTable _dataTable = new DataTable();
        private string _comboBoxSeperator = ",";

        private void ButtonCSVImport_Click(object sender, EventArgs e)
        {
            AddColumn.Hide();
            SpacesBox.Show();
            SpacesText.Show();
            AddColumn.Show();
            SaveCSV.Show();

            using OpenFileDialog openFileDialog = new OpenFileDialog() { FileName = "Dokument", DefaultExt = ".txt", Filter = "All Files|*.*" };
            try
            {
                var result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    var _csvDataLists = _csvFunctions.ReadCSVAndAddToList(path, _comboBoxSeperator);
                    _dataTable = _csvFunctions.BuildDataTableWithList(_csvDataLists);
                    dataGridView1.DataSource = _dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateCSV_Click(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            SaveCSV.Show();
            SpacesBox.Show();
            SpacesText.Show();
            AddColumn.Show();

            for (int i = 0; i < 5; i++)
            {
                _dataTable.Columns.Add("");
            }
            _dataTable.Rows.Add("");
            dataGridView1.DataSource = _dataTable;
        }

        private void AddColumn_Click(object sender, EventArgs e)
        {
            _dataTable.Columns.Add("");
        }

        private void SaveCSV_Click(object sender, EventArgs e)
        {
            List<List<string>> csvData = new List<List<string>>();
            List<string> rows;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    rows = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        rows.Add(cell.Value?.ToString()!);
                    }
                    csvData.Add(rows);
                }

                //datagridview creates automaticly a empty row in the last line
                csvData.RemoveAt(csvData.Count - 1);

                using SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    InitialDirectory = @"C:\",
                    Title = "Save text File",
                    CheckPathExists = true,
                    DefaultExt = "txt",
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 1,
                    RestoreDirectory = true,
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    _csvFunctions.CreateCSVFile(csvData, _comboBoxSeperator, int.Parse(SpacesBox.Text), saveFileDialog.FileName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ComboBoxSeperator_SelectedIndexChanged(object sender, EventArgs e) => _comboBoxSeperator = ComboBoxSeperator.SelectedItem.ToString()!;

        private void CompareCSV_Click(object sender, EventArgs e)
        {
            SaveCSV.Hide();
            SpacesBox.Hide();
            SpacesText.Hide();
            AddColumn.Hide();

            using OpenFileDialog openFileDialog = new OpenFileDialog() { FileName = "Dokument", DefaultExt = ".txt", Filter = "All Files|*.*" };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathToFirstCSVFile = openFileDialog.FileName;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pathToSecondCSVFile = openFileDialog.FileName;
                    List<List<string>> firstCSVFile = _csvFunctions.ReadCSVAndAddToList(pathToFirstCSVFile, _comboBoxSeperator);
                    List<List<string>> secondCSVFile = _csvFunctions.ReadCSVAndAddToList(pathToSecondCSVFile, _comboBoxSeperator);

                    CSVCompare compareCSV = new CSVCompare(firstCSVFile, secondCSVFile);
                    compareCSV.Show();
                }
            }
        }
    }
}