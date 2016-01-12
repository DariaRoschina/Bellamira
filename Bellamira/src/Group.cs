using SQLite;
namespace Bellamira
{
    public partial class Group

    {
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

        public int teacherId { get; }
        public int helperId { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", NameGroup, Id);
        }
    }
}
