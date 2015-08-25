using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Bellamira
{
    public partial class Group

    {
        //int tId;
        //int hID;
        //public Group(int tId, int HID)
        //{ this.tId = tId;
        //    this.hID = hID;
        //}

        [PrimaryKey, Unique, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(40), NotNull]
        public string NameGroup
        {
            get { return nameGroup; }
            set
            {
                nameGroup = value;
            }
        }

        // public int teacherId { get tId; }

        // public int helperId { get hId; }
        public int teacherId { get; }
        public int helperId { get; }

        public override string ToString()
        {
            return string.Format("{0} {1}", NameGroup, Id);
        }
    }
}
