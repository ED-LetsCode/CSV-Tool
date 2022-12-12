using System.Data;
using System.Drawing;
using System.Text;

namespace CSVLibrary
{
    /// <summary>
    /// Class for CSV edits
    /// </summary>
    public class CSVFunctions : ICSVFunctions
    {
        public CSVFunctions()
        {
        }

        /// <summary>
        /// Reads a CSV File 
        /// </summary>
        /// <param name="pathToCsvFile">Path to CSV File</param>
        /// <param name="seperator">Seperator to split the values examples => {"," ";" "." ...}</param>
        /// <returns>List of Lists with lines and line values</returns>
        public List<List<string>> ReadCSVAndAddToList(string pathToCsvFile, string seperator)
        {
            List<List<string>> csvData = new List<List<string>>();
            try
            {
                using StreamReader sr = new StreamReader(pathToCsvFile);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    List<string> csvLine = new List<string>();

                    if (line.Contains("\""))
                        csvData.Add(_EditLinesWithQuotes(line, seperator, csvLine));
                    else
                        line.Split(seperator).ToList().ForEach(x => csvLine.Add(x));

                    csvData.Add(csvLine);
                }
                sr.Close();
            }
            catch (Exception) { throw new Exception(); }
            return csvData;
        }

        /// <summary>
        /// Builds CSV List as text with line breaks and seperator
        /// </summary>
        /// <param name="csvData">List of CSV Data</param>
        /// <param name="emptySpaces">if user wants to format output then he can add empty spaces example => "Montag          Dienstag"</param>
        /// <param name="seperator">seperator for values in line</param>
        /// <returns>Whole CSV Text as string with line breaks</returns>
        public string CSVListToString(List<List<string>> csvData, int emptySpaces, string seperator)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string csvLines = string.Empty;
            foreach (var line in csvData)
            {
                foreach (var lineValues in line)
                {
                    //if item contains seperator then add qutoes (" ") to the string example => "Hello, World"
                    if (lineValues.Contains(seperator))
                        stringBuilder.Append($"\"{lineValues?.PadRight(emptySpaces)}\"").Append(seperator);
                    else
                        stringBuilder.Append(lineValues?.PadRight(emptySpaces)).Append(seperator);
                }
                //remove seperator on last index of line 
                stringBuilder.Length--;
                stringBuilder.Append(Environment.NewLine);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Creates a CSV file and saves it 
        /// </summary>
        /// <returns>CSV File as string with line breaks and seperator</returns>
        public string CreateCSVFile(List<List<string>> csvData, string seperator, int emptySpaces, string savingPath)
        {
            string? csvFile = CSVListToString(csvData, emptySpaces, seperator);
            try
            {
                File.WriteAllText(savingPath, csvFile);
            }
            catch (Exception) { throw new Exception(); }
            return csvFile;
        }

        /// <summary>
        /// Builds a Datatable with csvData List
        /// </summary>
        /// <param name="csvData"></param>
        /// <returns>DataTable object</returns>
        public DataTable BuildDataTableWithList(List<List<string>> csvData)
        {
            using DataTable dt = new DataTable();
            //to get columns from csv file read the first row
            csvData[0].ForEach(element => dt.Columns.Add(element));
            //to skip the column values skip index 0
            csvData.Skip(0).ToList().ForEach(row => dt.Rows.Add(row.ToArray()));
            return dt;
        }

        /// <summary>
        ///  Edits lines with quotes. TODO: This function is not perfect and performance technically not the fastest
        /// </summary>
        /// <returns>Edited line as List</returns>
        private List<string> _EditLinesWithQuotes(string line, string seperator, List<string> csvLine)
        {
            List<Point> points = _GetQuotesIndexPoints(line);

            //create array for strings 
            string[] substringValues = new string[points.Count];
            for (int i = 0; i < points.Count; i++)
            {
                //calculate length of string
                int length = Math.Abs(points[i].Y - points[i].X) + 1;
                //substring the value and add it to the index i of array
                substringValues[i] = line.Substring(points[i].X, length);
            }

            string placeHolder = $"ThisIsPlaceHolderNumber";
            for (int i = 0; i < substringValues.Length; i++)
            {
                //replace every value from array with placeholder example => Hello, World = ThisIsPlaceHolderNumber0
                line = line.Replace(substringValues[i], $"{placeHolder + i}");
            }

            //split the line with seperator
            string[] splittedTmpLine = line.Split(seperator.ToCharArray());
            for (int i = 0; i < splittedTmpLine.Length; i++)
            {
                //if the value contains placeholder then replace it with the value from array
                if (splittedTmpLine[i].Contains(placeHolder))
                {
                    for (int j = 0; j < substringValues.Length; j++)
                    {
                        if (splittedTmpLine[i].Contains(placeHolder + j))
                            splittedTmpLine[i] = splittedTmpLine[i].Replace(placeHolder + j, substringValues[j]).Replace("\"", "");
                    }
                }
            }
            splittedTmpLine.ToList().ForEach(x => csvLine.Add(x));
            return csvLine;
        }

        /// <summary>
        /// Gets the indexes of the quotes and saves it to a list of Points
        /// </summary>
        /// <param name="line"></param>
        /// <returns>List of Points</returns>
        private List<Point> _GetQuotesIndexPoints(string line)
        {
            List<Point> points = new List<Point>();

            int counter = 0, countedQuote = 0, firstQuoteIndex = 0, secondQuoteIndex = 0;
            char[] lineChars = line.ToCharArray();

            //count amount of quotes "
            foreach (var item in lineChars) { if (item == '"') countedQuote++; }

            for (int i = 0; i < lineChars.Length; i++)
            {
                if (lineChars[i] == '"')
                {
                    counter++;
                    //if 2 quotes counted then set secondQuotes
                    if (counter % 2 == 0)
                    {
                        secondQuoteIndex = i;
                        //add index of quotes to list example => firstQuoteIndex = 0, secondQuoteIndex = 10
                        points.Add(new Point(firstQuoteIndex, secondQuoteIndex));
                    }
                    else
                        firstQuoteIndex = i;
                }
            }
            return points;
        }

        /// <summary>
        /// Compares two csv files and adds the different values to a List of Points
        /// </summary>
        /// <returns>difference values between two csv files as string</returns>
        public string CompareCSVFiles(List<List<string>> firstCSVFile, List<List<string>> secondCSVFile, out List<Point> points)
        {
            //Points List for indexes of quotes
            points = new List<Point>();
            int row = 0, col = 0;
            string differences = string.Empty;
            foreach (var rows in secondCSVFile)
            {
                col = 0;
                foreach (var cols in rows)
                {
                    if (cols != firstCSVFile[row][col])
                    {
                        differences += $"CSV File 2   Column:\"{col}\"   " +
                                       $"Row: {row}    Value:\"{cols + 1}\" is not equal to " +
                                       $"File 1 => \"{firstCSVFile[row][col]}\"" + Environment.NewLine;
                        points.Add(new Point(col, row));
                    }
                    col++;
                }
                row++;
            }
            return differences;
        }
    }
}
