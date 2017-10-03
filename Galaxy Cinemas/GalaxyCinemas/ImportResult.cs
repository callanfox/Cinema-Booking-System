using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyCinemas
{
    public class ImportResult
    {
        public int TotalRows { get; set; }
        public int ImportedRows { get; set; }
        public int FailedRows { get; set; }
        private List<string> errorMessages = new List<string>();

        public List<string> ErrorMessages
        {
            get
            {
                return errorMessages;
            }
        }

        public ImportResult()
        {
            TotalRows = 0;
            ImportedRows = 0;
            FailedRows = 0;
            errorMessages.Clear();
        }
    }
}
