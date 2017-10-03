using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Common;
using Common.Business_Objects;

namespace GalaxyCinemas
{
    public class MovieImporter : BaseImporter
    {
        public MovieImporter(string fileName) : base(fileName) { }

        /// <summary>
        /// Import movie file. Filename has been provided in the constructor.
        /// </summary>
        public override void Import(object o)
        {
            // Initialise progress to zero for progress bar.
            Progress = 0f;
            ImportResult results = new ImportResult();

            try
            {
                // Read file
                string fileData = null;
                using (StreamReader reader = File.OpenText(fileName))
                {
                    fileData = reader.ReadToEnd();

                }

                string[] lines = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n'); // To deal with Windows, Mac and Linux line endings the same.


                // Check if first line is column names.
                string firstLine = lines[0];
                string[] columns = firstLine.Split(',');
                if (columns.Length == 2)
                {
                    if (columns[0].Trim().ToLower() == "movieid" && columns[1].Trim().ToLower() == "title")
                    {
                        lines[0] = "";
                    }
                }


                // Line count and line numbers to allow progress tracking.
                int lineCount = lines.Length;
                int lineNum = 1;


                // Get all movies.
                List<Movie> movies = DataLayer.DataLayer.GetAllMovies();

                foreach (string line in lines)
                {
                    // Check whether we need to stop after importing each line.
                    if (Stop)
                    {
                        return;
                    }


                    // Just to make it slow enough to test stopping functionality.
                    Thread.Sleep(500);

                    // Update progress of import.
                    try
                    {
                        Progress = lineNum / lineCount;
                        RaiseProgressChanged();


                        // Skip blank lines
                        if (line == "")
                        {
                            continue;
                        }
                        results.TotalRows++;


                        // Break up line by commas, each item in array will be one column.
                        columns = line.Split(',');
                        if (columns.Length != 2)
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: Wrong number of columns.", lineNum));
                            continue;
                        }


                        // Check the format of data, and update ImportResult accordingly.
                        int movieID = 0;
                        if (!int.TryParse(columns[0], out movieID))
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: MovieID is not a number.", lineNum));
                            continue;
                        }


                        string title = columns[1].Trim();
                        if (title == "")
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: Title is empty.", lineNum));
                            continue;
                        }


                        // Insert/update DB if okay.
                        Movie movieToUpdate = movies.Where(m => m.MovieID == movieID).FirstOrDefault();
                        if (movieToUpdate == null)
                        {
                            Movie movieToAdd = new Movie() { MovieID = movieID, Title = title };
                            DataLayer.DataLayer.AddMovie(movieToAdd);
                        }
                        else
                        {
                            movieToUpdate.Title = title;
                            DataLayer.DataLayer.UpdateMovie(movieToUpdate);
                        }
                        results.ImportedRows++;
                    }
                    finally
                    {
                        lineNum++;
                    }
                }
            }
            catch (IOException ioe)
            {
                results.ErrorMessages.Add("Input/Output error occurred.");
            }
            catch (Exception e)
            {
                results.ErrorMessages.Add("Unknown occurred.");
            }
            finally
            {
                RaiseCompleted(results);
            }
        }
    }
}