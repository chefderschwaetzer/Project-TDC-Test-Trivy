using System.Diagnostics;

namespace TDC.Models;
public class ToDoList
{
    private List<ListItem> items = new List<ListItem>();
    private List<Profile> members = new List<Profile>();
    private string name;
    private string id; // <base-id>-<member-id>

    #region constructors 
    public ToDoList(string name)
    {
        id = Guid.NewGuid().ToString();
        items = new List<ListItem>();
        members = new List<Profile>();
        this.name = name;
    }

    public ToDoList(string name, string listId)
    {
        id = listId;
        items = new List<ListItem>();
        members = new List<Profile>();
        this.name = name;
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
        Debug.WriteLine(id);
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
