using System;
using System.Collections.Generic;
using System.Text;
using Chardon.XamarinThemeManager;
using Xamarin.Forms;
using JLearn.Themes;

namespace JLearn.Services
{
    public class JLearnThemeManager : ThemeManager
    {
        private static readonly ResourceDictionary lightTheme = new LightTheme();

        private static readonly ResourceDictionary darkTheme = new DarkTheme();

        public JLearnThemeManager() : base(lightTheme, darkTheme)
        {
        }
    }
}
