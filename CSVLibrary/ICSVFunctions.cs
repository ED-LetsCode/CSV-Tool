using System.Data;
using System.Drawing;

namespace CSVLibrary
{
    public interface ICSVFunctions
    {
        /// <summary>
        /// Reads a CSV File 
        /// </summary>
        /// <param name="pathToCsvFile">Path to CSV File</param>
        /// <param name="seperator">Seperator to split the values examples => {"," ";" "." ...}</param>
        /// <returns>List of Lists with lines and line values</returns>
        public List<List<string>> ReadCSVAndAddToList(string pathToCsvFile, string seperator);

        /// <summary>
        /// Builds CSV List as text with line breaks and seperator
        /// </summary>
        /// <param name="csvData">List of CSV Data</param>
        /// <param name="emptySpaces">if user wants to format output then he can add empty spaces example => "Montag          Dienstag"</param>
        /// <param name="seperator">seperator for values in line</param>
        /// <returns>Whole CSV Text as string with line breaks</returns>
        public string CSVListToString(List<List<string>> csvData, int emptySpaces, string seperator);

        /// <summary>
        /// Creates a CSV file and saves it 
        /// </summary>
        /// <returns>CSV File as string with line breaks and seperator</returns>
        public string CreateCSVFile(List<List<string>> csvData, string seperator, int emptySpaces, string savingPath);

        /// <summary>
        /// Builds a Datatable with csvData List
        /// </summary>
        /// <param name="csvData"></param>
        /// <returns>DataTable object</returns>
        public DataTable BuildDataTableWithList(List<List<string>> csvData);

        /// <summary>
        /// Compares two csv files and adds the different values to a List of Points
        /// </summary>
        /// <returns>difference values between two csv files as string</returns>
        public string CompareCSVFiles(List<List<string>> firstCSVFile, List<List<string>> secondCSVFile, out List<Point> points);
    }
}
