using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace JLearn.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
        }

        public string CurrentVersion => $"{AppInfo.VersionString}.{AppInfo.BuildString}";
    }
}