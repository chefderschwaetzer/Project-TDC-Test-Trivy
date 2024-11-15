using System.Diagnostics;
using System.Threading.Tasks;
using TDC.Models;

namespace TDC;

public partial class ToDoListView : ContentPage
{
    private ToDoList list;
    private ListRepository listRepository;
    public ToDoListView()
	{
		InitializeComponent();
        listRepository = new ListRepository();
        list = new ToDoList("<no-name>"); //can't be saved with default name! -> user has to enter name
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
        // Hole den Text aus dem TitleEntry
        string listName = TitleEntry.Text?.Trim();

        // Wenn der Benutzer keinen Namen eingegeben hat, fordere ihn dazu auf
        if (string.IsNullOrWhiteSpace(listName))
        {
            var result = await DisplayPromptAsync("Enter List Name", "Please provide a name for the list:");
            if (!string.IsNullOrWhiteSpace(result))
            {
                listName = result;
                TitleEntry.Text = result;
            }
        }
        // Setze den Namen der Liste
        if (!string.IsNullOrWhiteSpace(listName))
        {
            list.SetName(listName);
        }
        // Speichere die Liste
        listRepository.AddList(list);
        PrintListToConsole();
    }
    private void PrintListToConsole()
    {
        // Gehe alle ListItems der ToDoList durch und gib deren Eigenschaften aus
        foreach (var item in list.GetItems())
        {
            Debug.WriteLine($"Description: {item.GetDescription()}, Done: {item.IsDone()}, Effort: {item.GetEffort()}");
        }
    }
    #endregion
}