namespace TDC.Models;
public class Hairstyle
{
    private string color;
    private int styleID;

    #region constructors
    public Hairstyle(string color, int styleID) 
    { 
        this.color = color;
        this.styleID = styleID;
    }
    #endregion

    #region getters & setters
    public void SetColor(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetStyle(int styleID)
    {
        this.styleID = styleID;
    }

    public int GetStyle()
    {
        return styleID;
    }
    #endregion
}

