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

namespace AppHW3
{
    [Activity(Label = "mailAct")]
    public class mailAct : Activity
    {
        TextView ftext;
        TextView stext;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.mailActLay);

            modifyText();

            // Create your application here
        }

        public void modifyText()

        {
            ftext = FindViewById<TextView>(Resource.Id.textView1);
            ftext.Text = base.Intent.GetStringExtra("mySub");

            stext = FindViewById<TextView>(Resource.Id.textView2);
            stext.Text = base.Intent.GetStringExtra("mail");


        }
    }
}