using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PickYourOwnDestiny.UI
{
    class dbHelper
    {
        String dbConnectionString;
        SQLiteConnection con;
        
        public  dbHelper(String dbFile)
        {
            dbConnectionString = String.Format("Data Source={0}", dbFile);
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

    }
}
