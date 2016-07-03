using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using System.Collections;

namespace SQLiteTutorial
{
    public class MemberDatabase
    {
        private SQLiteConnection conn;
        //CREATE
        public MemberDatabase()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Member>();
        }

        //READ
        public IEnumerable<Member> GetMembers()
        {
            var members = (from mem in conn.Table<Member>() select mem);
            return members.ToList();
        }
        //INSERT
        public string AddMember(Member member)
        {
            conn.Insert(member);
            return "success";
        }
        //DELETE
        public string DeleteMember(int id)
        {
            conn.Delete<Member>(id);
            return "success";
        }
    }
}
