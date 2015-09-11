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
        string g;
        //int t;
        public User(string g /*,int t*/)
        { /*this.t = t;*/
            this.g = g;

        }
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
        public int Type_Id { get/* { return t*/; }

        public string Student_Group_Id { get { return g; } }
        //   public int Student_Group_Id { get ; set ;  }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} ", Id, Fam, Name, Otch, Student_Group_Id);
        }
    }
}
