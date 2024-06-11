using Syncfusion.Maui.Themes;

namespace RadioButton {
    public partial class MainPage : ContentPage {
        

        public MainPage() {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null) {
                var theme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
                if (theme != null) {
                    if (theme.SfVisualTheme is SfVisuals.DarkDefault) {
                        theme.SfVisualTheme = SfVisuals.LightDefault;
                        Application.Current.UserAppTheme = AppTheme.Light;
                    }
                    else {
                        theme.SfVisualTheme = SfVisuals.DarkDefault;
                        Application.Current.UserAppTheme = AppTheme.Dark;
                    }
                }
            }
        }
    }

}
