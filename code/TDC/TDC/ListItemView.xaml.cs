using System.Collections.ObjectModel;
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
        this.FindByName<Picker>("TaskPicker").SelectedIndex = item.GetEffort() - 1;
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

    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedIndex = picker.SelectedIndex;

        if(selectedIndex != -1)
            item.SetEffort(selectedIndex + 1);
    }
    #endregion


    #region Picker
    #endregion

    #region publics

    public ListItem GetItem()
    {
        return item;
    }

#endregion
}