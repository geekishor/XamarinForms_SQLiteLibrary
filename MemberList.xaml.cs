using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SQLiteTutorial
{
    public partial class MemberList : ContentPage
    {
        public MemberDatabase memberDatabase;
        public MemberList()
        {
            InitializeComponent();

            memberDatabase = new MemberDatabase();
            var members = memberDatabase.GetMembers();
            listMembers.ItemsSource = members;
           // BindingContext = this;
        }

        public async void OnSelected(object obj, ItemTappedEventArgs args)
        {
            var member = args.Item as Member;
            await DisplayAlert("You selected", member.Name + " " + member.Age, "OK");
        }
    }
}
