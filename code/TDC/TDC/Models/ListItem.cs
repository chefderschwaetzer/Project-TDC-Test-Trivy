namespace TDC.Models;
public class ListItem
{
    private string description;
    private bool done;
    private List<Profile> finishedMembers;
    private int effort;

    #region constructors
    public ListItem() {
        description = "";
        done = false;
        finishedMembers = new List<Profile>();
        effort = 0;
    }

    public ListItem(string description, bool done, List<Profile> finishedMembers, int effort)
    {
        this.description = description;
        this.done = done;
        this.finishedMembers = finishedMembers;
        this.effort = effort;
    }
    #endregion

    #region getters & setters
    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void ToggleDone()
    {
        done = !done;
    }

    public bool IsDone()
    {
        return done;
    }

    public void AddFinishedMember(Profile member)
    {
        finishedMembers.Add(member);
    }

    public void RemoveFinishedMember(Profile member)
    {
        finishedMembers.Remove(member);
    }

    public List<Profile> GetFinishedMembers()
    {
        return finishedMembers;
    }

    public int GetEffort() {
        return effort;
    }

    public void SetEffort(int effort) { 
        this.effort = effort;
    }
    #endregion
}
