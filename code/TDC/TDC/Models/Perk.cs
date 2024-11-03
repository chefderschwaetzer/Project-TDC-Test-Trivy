namespace TDC.Models;
public class Perk {
    private readonly int perkID;
    private readonly string description;

    #region constructors
    public Perk(int perkID, string description) {
        this.perkID = perkID;
        this.description = description;
    }
    #endregion

    #region getters & setters
    public int GetPerkID() { 
        return perkID;
    }

    public string GetDescription() { 
        return description;
    }
    #endregion
}

