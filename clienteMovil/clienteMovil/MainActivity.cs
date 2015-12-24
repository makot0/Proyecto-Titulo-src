using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace clienteMovil
{
    [Activity(Label = "clienteMovil", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            Button btn_Scanner = FindViewById<Button>(Resource.Id.btn_Scanner);
            btn_Scanner.Click += async (sender, e) =>
            {

                //NOTE: On Android, you MUST pass a Context into the Constructor!
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                var result = await scanner.Scan();

                if (result != null)
                    Console.WriteLine("Scanned Barcode: " + result.Text);
            };
        }
    }
}

