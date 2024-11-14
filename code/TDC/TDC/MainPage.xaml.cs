namespace TDC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNewListClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///ToDoListPage");
        }
    }

}