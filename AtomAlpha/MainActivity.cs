using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using AtomAlpha.Model;

namespace AtomAlpha
{
    [Activity(Label = "AtomAlpha", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Person> mItems;
        private ListView mlistView;
        private Button mButtonSignUp;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Signup);

           /* mButtonSignUp = FindViewById<Button>(Resource.Id.buttonSignUp);
            mButtonSignUp.Click += (object sender, System.EventArgs e) =>
            {
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                DialogSignUp signUpDialog = new DialogSignUp();
                signUpDialog.Show(transaction, "Dialog Fragment");

            };*/

            mlistView = FindViewById<ListView>(Resource.Id.listview1);
            mItems = new List<Person>();
            mItems.Add(new Person("Doe", "John", "36", "Homme"));
            mItems.Add(new Person("Daiki", "Aomine", "18", "Homme"));
            mItems.Add(new Person("Saitama", "Gion", "32", "Homme"));

            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleExpandableListItem1, mItems);
            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mlistView.Adapter = adapter;
        }

    }
}

