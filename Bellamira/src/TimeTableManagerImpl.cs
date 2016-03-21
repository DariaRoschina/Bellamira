using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice;

namespace Bellamira.src
{
    public class TimeTableManagerImpl : TimeTableManagerDisp_
    {
        public override bool addTimeTableEntry(TimeTableEntry te, Current current__)
        {
            Console.WriteLine("TimeTableManager.addTimeTableEntry() called");
            try
            {
                SDB.getInstance().getDb().Insert(te);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public override bool delTimeTableEntry(int id, Current current__)
        {
            Console.WriteLine("TimeTableManager.delTimeTableEntry() called");
            try
            {
                SDB.getInstance().getDb().Delete<TimeTableEntry>(id);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public override TimeTableEntry[] getAllTimeTable(Current current__)
        {
            Console.WriteLine("TimeTableManager.getAllTimeTable() called");
            TimeTableEntry[] tmp = SDB.getInstance().getDb().Table<TimeTableEntry>().ToArray();
            SDB.getInstance().disconnect();
            return tmp;
        }

        public override TimeTableEntry[] getTimeTableForGroup(int id, Current current__)
        {
            Console.WriteLine("TimeTableManager.getTimeTableForGroup() called");
            TimeTableEntry[] tmp = SDB.getInstance().getDb().Table<TimeTableEntry>().ToArray();
            TimeTableEntry[] tmp1 = new TimeTableEntry[555];
            int j = 0;
            SDB.getInstance().disconnect();
            foreach (var i in tmp)
            {
                if (i.GroupId == id)
                {
                    SDB.getInstance().disconnect();
                    tmp1[j] = i;
                        j++;
                 }
            }
            return tmp1;
        }

        public override bool modifyTimeTableEntry(TimeTableEntry te, int id, Current current__)
        {
            Console.WriteLine("TimeTableManager.modifyTimeTableEntry() called");
            try
            {

                SDB.getInstance().getDb().Update(te);
                SDB.getInstance().disconnect();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }
    }
}
