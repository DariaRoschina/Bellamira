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
       int  g;
        //int t;
        public User(int g /*,int t*/)
        { /*this.t = t;*/
            this.g = g;

        }
        [PrimaryKey, Unique]
        public string Login
        {
            get { return login; }
            
             set { login = value; }

        }

     
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [MaxLength(40), NotNull]
        public string Otch
        {
            get { return otch; }
            set { otch = value; }
        }

        
        public int Type_Id
        {
            get { return type.Id; }
            set { type = SDB.getInstance().getDb().Find<UserType>(value); }
        }
        public int Student_Group_Id {

            get { return g; }
             set { g = SDB.getInstance().getDb().Find<Group>(value).Id; }


        }
        //   public int Student_Group_Id { get ; set ;  }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} ", Login, Password, Fam, Name, Otch, Student_Group_Id);
        }
    }
}
