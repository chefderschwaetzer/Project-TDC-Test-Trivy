namespace TDC.Models;
public class ToDoList
{
    private List<ListItem> items = new List<ListItem>();
    private List<Profile> members = new List<Profile>();
    private string name;
    private string id;

    #region constructors 
    public ToDoList(string name)
    {
        //TO-DO: add logic with new id etc
        items = new List<ListItem>();
        members = new List<Profile>();
        this.name = name;
    }

    public ToDoList(int id)
    {
        //TO-DO: init object via ID
    }
    #endregion

    #region getters & setters
    public void AddItem(ListItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(ListItem item)
    {
        items.Remove(item);
    }

    public List<ListItem> GetItems()
    {
        return items;
    }

    public void AddMember(Profile member)
    {
        members.Add(member);
    }

    public void RemoveMember(Profile member)
    {
        members.Remove(member);
    }

    public List<Profile> GetMembers()
    {
        return members;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public string GetID()
    {
        return id;
    }
    #endregion

    public void DeleteList()
    {

    }

    public void FinishList()
    {
        
    }
}
