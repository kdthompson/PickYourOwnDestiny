using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using PickYourOwnDestiny.Entities;

namespace PickYourOwnDestiny.UI
{
    class dbHelper
    {
        String dbConnectionString;
        SQLiteConnection con;
        private static dbHelper instance;
        String mConnectionString = "c:\\PYOD\\PYOD.db";

        private  dbHelper()
        {
            dbConnectionString = String.Format("Data Source={0}", mConnectionString);
            con = new SQLiteConnection(dbConnectionString);
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static dbHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new dbHelper();
                }
                return instance;
            }
        }

        public bool createCharacter(String charName,String charRace,String charClass, int mStrength, int mDex, int mKnow, int mHitPoints, int mHeroPoints)
        {
            String mSQL = String.Format("insert into Character(Name,Race,CharClass,Strength,Dexterity,Knowledge,HitPoints,HeroPoints,StoryTracker)" +
                                        "values('{0}','{1}','{2}',{3},{4},{5},{6},{7},1)", charName, charRace, charClass, mStrength, mDex, mKnow, mHitPoints, mHeroPoints);
            SQLiteCommand mCommand = new SQLiteCommand(mSQL,con);
         try
            {
                mCommand.ExecuteNonQuery();
            }
            catch (Exception fail)
            {
                System.Console.Write(fail);
                return false;
            }
  
            return true;
        }
        public Adventure getAdventure(int StoryTrackerIndex)
        {
            ArrayList adventureList = new ArrayList();
            string sql = "select * from Adventure where StoryTracker = " + StoryTrackerIndex;
            Adventure _Adventure = null;
            SQLiteCommand cmd = new SQLiteCommand(sql,con);
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                int max = sr.FieldCount;

                for (int x = 0; x < max; x++)
                {
                    adventureList.Add(sr.GetValue(x));
                }


                _Adventure = new Adventure(adventureList);
 
            }
            return _Adventure;
        }
        public Character getCharacter(string characterName)
        {
            ArrayList characterList = new ArrayList();
            string sql = String.Format("select * from Character where Name = '{0}'", characterName);
            Character _Character = null;
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader sr = cmd.ExecuteReader();
            while (sr.Read())
            {
                int max = sr.FieldCount;

                for (int x = 0; x < max; x++)
                {
                    characterList.Add(sr.GetValue(x));
                }


                _Character = new Character(characterList);

            }
            return _Character;
        }

        public ArrayList getAtributeList(String tableName,String fieldName, String whereClause)
        {
            ArrayList attributeList = new ArrayList();

            String sql = String.Format("select {0} from {1} {2}", fieldName, tableName, whereClause);
            SQLiteCommand cmd = new SQLiteCommand(sql,con);
            SQLiteDataReader sr = cmd.ExecuteReader();

            while (sr.Read())
            {
                attributeList.Add(sr[fieldName]);
            }

            return attributeList;
        }
        public int returnCharStat(String tableName, String fieldName, String where)
        {
            String holder = String.Empty;
            String search = String.Format("SELECT {0} from {1} {2}", fieldName, tableName, where);
            SQLiteCommand c = new SQLiteCommand(search, con);
            SQLiteDataReader dr = c.ExecuteReader();
            dr.Read();
            int max = dr.FieldCount;
            for (int i = 0; i < max; i++)
            {
                holder = dr[i++].ToString();
            }
            return int.Parse(holder);
        }
        public ArrayList returnChallenge(String tableName, String fieldOne, String fieldTwo, String where)
        {
            ArrayList holder = new ArrayList();
            String search = String.Format("SELECT {0}, {1} from {2} {3}", fieldOne, fieldTwo, tableName, where);
            SQLiteCommand c = new SQLiteCommand(search, con);
            SQLiteDataReader dr = c.ExecuteReader();
            int max = dr.FieldCount;
            for (int i = 0; i < max; i++)
            {
                holder.Add(dr[i++]);
            }
            return holder;
        }

    }
}
