using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTutorial
{
    public interface ISQLite
    {
        SQLite.SQLiteConnection GetConnection();
    }
}
