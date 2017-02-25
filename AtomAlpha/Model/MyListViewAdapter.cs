using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AtomAlpha.Model
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        private List<Person> mItems;
        private Context mContext;

        public MyListViewAdapter(Context context, List<Person> items)
        {
            mContext = context;
            mItems = items;
        }

        public override Person this[int position]
        {
            get
            {
                return mItems[position];
            }
        }

        public override int Count
        {
            get
            {
                return mItems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if(row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.listview_row, null, false);
            }

            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.textViewLastName);
            txtLastName.Text = mItems[position].LastName;

            TextView txtFirstName = row.FindViewById<TextView>(Resource.Id.textViewFirstName);
            txtFirstName.Text = mItems[position].FirstName;

            TextView txtGender = row.FindViewById<TextView>(Resource.Id.textViewGender);
            txtGender.Text = mItems[position].Gender;

            TextView txtAge = row.FindViewById<TextView>(Resource.Id.textViewAge);
            txtAge.Text = mItems[position].Age;

            return row;
        }
    }
}