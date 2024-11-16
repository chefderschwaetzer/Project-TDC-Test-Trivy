using TDC.Models;

namespace TDC;

public partial class ListItemView : ContentView
{
    private readonly ListItem item;

    #region constructors
    public ListItemView(ListItem item)
    {
        this.item = item;
        InitializeComponent();
        this.FindByName<Entry>("TaskEntry").Text = item.GetDescription();
        this.FindByName<CheckBox>("TaskCheckBox").IsChecked = item.IsDone();
    }

    #endregion

    #region event listeners
    private void DescriptionChanged(object sender, EventArgs e)
    {
        item.SetDescription(this.FindByName<Entry>("TaskEntry").Text);
    }
    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        item.ToggleDone();  // Toggle the done status of the item when the checkbox is checked or unchecked
    }
    #endregion

    #region publics

    public ListItem GetItem()
    {
        return item;
    }
    #endregion
}