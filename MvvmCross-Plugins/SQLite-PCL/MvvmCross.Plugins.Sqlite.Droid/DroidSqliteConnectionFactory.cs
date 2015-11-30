using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using System.IO;
using Environment = System.Environment;

namespace MvvmCross.Plugins.Sqlite.Droid
{
    public class DroidSqliteConnectionFactory : MvxSqliteConnectionFactoryBase
    {
        public override ISQLitePlatform CurrentPlattform => new SQLitePlatformAndroid();

        public override string GetPlattformDatabasePath(string databaseName)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, databaseName);
        }
    }
}