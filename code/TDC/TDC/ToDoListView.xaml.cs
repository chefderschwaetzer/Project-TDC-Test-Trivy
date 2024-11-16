using System.Threading.Tasks;
using TDC.Models;

namespace TDC;

public partial class ToDoListView : ContentPage
{
    private ToDoList list;
	public ToDoListView()
	{
		InitializeComponent();
        list = new ToDoList("<no-name>"); //can't be saved with default name! -> user has to enter name
    }

    #region listeners

    private void OnNewItemClicked(object sender, EventArgs e)
    {
        list.AddItem(new ListItem("", [], 5));

        // clear container
        ItemsContainer.Children.Clear();

        foreach (var item in list.GetItems())
        {
            var listItemView = new ListItemView(item);

            // add as child element
            ItemsContainer.Children.Add(listItemView);
        }
    }

    #endregion
}