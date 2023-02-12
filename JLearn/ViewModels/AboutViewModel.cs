using System.Windows.Input;

using Microsoft.Maui;
using Microsoft.Maui.Controls;

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