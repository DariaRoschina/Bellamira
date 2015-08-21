using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Bellamira
{
    public partial class User
    {
        [PrimaryKey, Unique, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(40), NotNull]
        public string Fam
        {
            get { return fam; }
            set
            {
                fam = value;
            }
        }

        [MaxLength(40), NotNull]
        public string Name { get; set; }

        [MaxLength(40), NotNull]
        public string Otch { get; set; }

        [NotNull]
        public int Type_Id { get; set; }

        public int Student_Group_Id { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Fam, Name, Otch);
        }
    }
}
