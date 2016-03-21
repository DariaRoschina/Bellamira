using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Bellamira
{
    public partial class TimeTableEntry
    {
        [PrimaryKey, Unique, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(40), NotNull]
        public string DayWeek
        {
            get { return dayWeek; }
            set
            {
                dayWeek = value;
            }
        }

        [MaxLength(40), NotNull]
        public long Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }

        public int teacherId { get; set; }
        public int GroupId { get; set; }


        public override string ToString()
        {
            return string.Format("{0} {1} {2}",Id, DayWeek,Time);
        }
    }
}
