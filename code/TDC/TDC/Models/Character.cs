namespace TDC.Models;

public class Character
{
    private int xp;
    private int points;
    private List<Perk> perks = new List<Perk>();
    private List<int> outfits;
    private int currentOutfit;
    private string color;
    private int face;
    private Hairstyle hairstyle;

    #region constructors
    public Character() 
    {
        perks = new List<Perk>();
        outfits = new List<int>();
        color = "#000000";
        hairstyle = new Hairstyle(color, 0);
    }

    public Character(int xp, int points, List<Perk> perks, List<int> outfits, int currentOutfit, string color, int face, Hairstyle hairstyle)
    {
        this.xp = xp;
        this.points = points;
        this.perks = perks;
        this.outfits = outfits;
        this.currentOutfit = currentOutfit;
        this.color = color;
        this.face = face;
        this.hairstyle = hairstyle;
    }
    #endregion

    #region getters & setters
    public void AddXP(int xp)
    {
        this.xp += xp;
    }

    public int GetXP()
    {
        return xp;
    }

    public void AddPoints(int points)
    {
        this.points += points;
    }

    public int GetPoints()
    {
        return points;
    }

    public void AddPerk(Perk perk)
    {
        perks.Add(perk);
    }

    public List<Perk> GetPerks()
    {
        return perks;
    }

    public void AddOutfit(int outfitID)
    {
        
    }

    public List<int> GetOutfits()
    {
        return outfits;
    }

    public void SetCurrentOutfit(int outfitID)
    {
        currentOutfit = outfitID;
    }

    public int GetCurrentOutfit()
    {
        return currentOutfit;
    }

    public void SetColor(string colorCode)
    {
        color = colorCode;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetFace(int faceID)
    {
        face = faceID;
    }

    public int GetFace()
    {
        return face;
    }

    public void SetHairstyle(Hairstyle hair)
    {
        hairstyle = hair;
    }

    public Hairstyle GetHairstyle()
    {
        return hairstyle;
    }
    #endregion
}
