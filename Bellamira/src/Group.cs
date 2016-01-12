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
        [PrimaryKey, Unique, AutoIncrement]
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }

        [MaxLength(40), NotNull]
        public string NameGroup
        {
            get { return nameGroup; }
            set
            {
                nameGroup = value;
            }
        }


        public int teacherId { get; }
        public int helperId { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", NameGroup, Id);
        }
    }
}
