using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SQLiteTutorial
{
    public partial class FormsPage : ContentPage
    {
        public MemberDatabase memberDatabase;
        public Member member;

        public FormsPage()
        {
            InitializeComponent();
        }

        public void InsertMember(object o, EventArgs e)
        {
            member = new Member();
            memberDatabase = new MemberDatabase();
            member.Name = memberName.Text;
            member.Age = memberAge.Text;
            memberDatabase.AddMember(member);
        }

        public async void ShowMembers(object o, EventArgs e)
        {
            await Navigation.PushModalAsync(new MemberList());
        }
    }
}
