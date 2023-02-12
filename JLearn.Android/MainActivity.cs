
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;

namespace JLearn.Droid
{
    [Activity(Label = "JLearn", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //this.TabLayoutResource = Resource.Layout.Tabbar;
            //this.ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
        }
    }
}