using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Bellamira;
namespace Bellamira
{
    public partial class UserType
    {
        [PrimaryKey, Unique, AutoIncrement]
        public int Id
        {

            get { return id; }

          private  set { id = value; }
        }
        [MaxLength(40), NotNull]
        public string NameType
        {
            get
            {
                return nameType;
            }
            set
            {
                nameType = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Id, NameType);
        }

    }
}
