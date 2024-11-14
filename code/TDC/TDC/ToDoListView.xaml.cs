namespace TDC;

public partial class ToDoListView : ContentPage
{
	public ToDoListView()
	{
		InitializeComponent();
	}

    private void OnEditButtonClicked(object sender, EventArgs e)
    {
        ImageButton? imageButton = sender as ImageButton;
        TitleEntry.IsReadOnly = !TitleEntry.IsReadOnly;
        if (imageButton != null)
        {
            if (TitleEntry.IsReadOnly)
            {
                imageButton.BackgroundColor = Color.FromArgb("#424242");
                return;
            }

            imageButton.BackgroundColor = Color.FromArgb("#800080");
            
        }
    }
}