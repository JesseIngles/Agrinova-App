using Agrinova.ViewModel;

namespace Agrinova.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }

        private void Irrigar_Clicked(object sender, EventArgs e)
        {

        }
    }
}