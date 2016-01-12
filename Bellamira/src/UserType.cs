using SQLite;
namespace Bellamira
{
    public partial class UserType
    {
        [PrimaryKey, Unique, AutoIncrement]
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
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
