using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Business_Objects
{
    public class Session
    {
        public int SessionID { get; set; }
        public int MovieID { get; set; }
        public DateTime SessionDate { get; set; }
        public byte CinemaNumber { get; set; }
        public string ShortFormat
        {
            get 
            {
                return string.Format("{0:HH:mm} -- Cinema {1}", SessionDate, CinemaNumber);
            }
        }
    }
}
