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
    }

    #endregion

    #region event listeners
    private void DescriptionChanged(object sender, EventArgs e)
    {
        item.SetDescription(this.FindByName<Entry>("TaskEntry").Text);
    }
    #endregion

    #region publics

    public ListItem GetItem()
    {
        return item;
    }
    #endregion
}