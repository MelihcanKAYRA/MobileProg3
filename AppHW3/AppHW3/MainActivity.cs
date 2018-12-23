using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace AppHW3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button but;
        Button but2;
        TextView mail;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            but = FindViewById<Button>(Resource.Id.button1);
            but2 = FindViewById<Button>(Resource.Id.button4);

            but.Click += (s, arg) =>
            {
                PopupMenu menu = new PopupMenu(this, but);
                menu.Inflate(Resource.Menu.pop);

                menu.MenuItemClick += (s1, arg1) =>
                {

                    mail = FindViewById<TextView>(Resource.Id.TextView2);

                    var intent = new Intent(this, typeof(mailAct));
                    intent.PutExtra("mySub", arg1.Item.TitleFormatted);
                    intent.PutExtra("mail", mail.Text);
                    StartActivity(intent);
                };
                menu.Show();
            };

            but2.Click += (ss, argu) =>
            {
                PopupMenu menu2 = new PopupMenu(this, but2);
                menu2.Inflate(Resource.Menu.pop);

                menu2.MenuItemClick += (s1, arg1) =>
                {

                    mail = FindViewById<TextView>(Resource.Id.textView4);

                    var intent = new Intent(this, typeof(mailAct));
                    intent.PutExtra("mySub", arg1.Item.TitleFormatted);
                    intent.PutExtra("mail", mail.Text);
                    StartActivity(intent);
                };

                menu2.Show();
            };
        }
    }
}