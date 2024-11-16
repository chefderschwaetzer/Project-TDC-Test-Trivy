using TDC.Models;

#if ANDROID
using Android.Views;
#endif

namespace TDC;

public partial class ToDoListView : ContentPage, IOnPageKeyDown
{
    private ToDoList list;
    private ListRepository listRepository;
    public ToDoListView()
	{
        InitializeComponent();
        listRepository = new ListRepository();
        list = new ToDoList("");
    }

    #region listeners

    private void OnNewItemClicked(object sender, EventArgs e)
    {
        list.AddItem(new ListItem("", new List<Profile>(), 5));

        var listItemView = new ListItemView(list.GetItems().Last());
        ItemsContainer.Children.Add(listItemView);
    }
    private async void OnSaveListClicked(object sender, EventArgs e)
    {
        // get name from input field
        string listName = TitleEntry.Text?.Trim();

        // if no name entered, ask user to put name
        if (string.IsNullOrWhiteSpace(listName))
        {
            var result = await DisplayPromptAsync("Enter List Name", "Please provide a name for the list:");
            if (!string.IsNullOrWhiteSpace(result))
            {
                listName = result;
                TitleEntry.Text = result;
            }
        }
        // set name of list
        if (!string.IsNullOrWhiteSpace(listName))
        {
            list.SetName(listName);
        }
        // save list
        listRepository.AddList(list);
    }

    private void BackspaceEmitted()
    {
        foreach (var item in ItemsContainer.Children) {
            ListItemView view = (ListItemView)item;

            if(view.FindByName<Entry>("TaskEntry").IsFocused)
            {
                view.OnItemRemove();
                return;
            }
        }
    }

    #if ANDROID
    public bool OnPageKeyDown(Keycode keyCode, KeyEvent e) {
        if(keyCode == Keycode.Del) {
                BackspaceEmitted();
                return true;
        }
        return false;
    }
    #endif
    #endregion
}