namespace TDC.Models;
public class Account: Profile
{
    private List<Profile> friends = new List<Profile>();
    private List<ToDoList> lists = new List<ToDoList>();
    private string email;
    private string password;
    private Character character;

    #region constructors
    public Account(int id, string name, string picture, string description, string email, string password)
    : base(id, name, picture, description)
    {
        this.friends = new List<Profile>();
        this.lists = new List<ToDoList>();
        character = new Character();
        this.email = email;
        this.password = password;
        this.character = character;
    }

    public Account(int id):base(id)
    {
        //TO-DO: init rest via id -> existing account
    }
    #endregion

    #region getters & setters
    public void SetName(string name) { 
        this.name = name;
    }

    public void SetPicture(string picture) { 
        this.picture = picture;
    }

    public void SetDescription(string description) { 
        this.description = description;
    }

    public void SetPassword(string password)
    {
        this.password = password;
    }

    public string GetPassword()
    {
        return password;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void AddFriend(Profile friend)
    {
        friends.Add(friend);
    }

    public void RemoveFriend(Profile friend)
    {
        friends.Remove(friend);
    }

    public List<Profile> GetFriendList()
    {
        return friends;
    }

    public void AddList(ToDoList list)
    {
        lists.Add(list);
    }

    public void RemoveList(ToDoList list)
    {
        lists.Remove(list);
    }

    public List<ToDoList> GetLists()
    {
        return lists;
    }
    #endregion
}

