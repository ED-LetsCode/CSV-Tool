using CSVLibrary;

namespace CSVWinForm
{
    public partial class CSVCompare : Form
    {
        public CSVCompare(List<List<string>> firstCSVFile, List<List<string>> secondCSVFile)
        {
            InitializeComponent();
            _firstCSVFile = firstCSVFile;
            _secondCSVFile = secondCSVFile;
        }

        private List<List<string>> _firstCSVFile;
        private List<List<string>> _secondCSVFile;
        private CSVFunctions _csvFunctions = new CSVFunctions();

        private void CompareForm_Load(object sender, EventArgs e)
        {
            try
            {
                TextBox.Text = _csvFunctions.CompareCSVFiles(_firstCSVFile, _secondCSVFile, out List<Point> points);
                File1DataGridView.DataSource = _csvFunctions.BuildDataTableWithList(_firstCSVFile);
                File2DataGridView.DataSource = _csvFunctions.BuildDataTableWithList(_secondCSVFile);

                foreach (var point in points)
                {
                    File1DataGridView.Rows[point.Y].Cells[point.X].Style.BackColor = Color.LightGreen;
                    File2DataGridView.Rows[point.Y].Cells[point.X].Style.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
