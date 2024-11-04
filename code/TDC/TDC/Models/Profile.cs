namespace TDC.Models;
public class Profile
{
    protected int id;
    protected string name;
    protected string picture;
    protected string description;
    protected int level;

    #region constructors
    public Profile(int id, string name, string picture, string description)
    {
        this.id = id;
        this.name = name;
        this.picture = picture;
        this.description = description;
        level = 0;
    }

    #endregion

    #region getters & setters
    public int GetID()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public string GetPicture()
    {
        return picture;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetLevel()
    {
        return level;
    }
    #endregion
}

