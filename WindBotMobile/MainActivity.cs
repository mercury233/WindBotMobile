using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using WindBot;

namespace WindBotMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText LogEdit;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            LogEdit = FindViewById<EditText>(Resource.Id.editText1);

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += Test1;
            Program.Assets = this.Assets;
            Program.MainActivity = this;
            Program.InitAndroid();
            Toast.MakeText(this, "咕咕咕", ToastLength.Short).Show();
            // try
            //{


            //}
            // catch (Exception e)
            //{
            //     EditText textview = FindViewById<EditText>(Resource.Id.editText1);
            //    textview.Text = e.Message;
            // }
        }

        private void Test1(object sender, EventArgs e)
        {
            //YGOSharp.OCGWrapper.NamedCardsManager.Init("/storage/emulated/0/ygocore/cards.cdb");
            //YGOSharp.OCGWrapper.NamedCard card1 = YGOSharp.OCGWrapper.NamedCard.Get(22862454);
            WindBotInfo Info = new WindBotInfo();
            Program.Run(Info);
        }

        public void AddLog(string log)
        {
            LogEdit.Text = LogEdit.Text + log + "\n";
        }
    }
}

