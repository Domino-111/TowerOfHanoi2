using UnityEngine;

// Scriptable Object: Storage object with its instances created in the assets window

[CreateAssetMenu(fileName = "Colour Palette")]

public class ColorPalette : ScriptableObject
{
    public Color backgroundColor = new Color(0, 0, 0, 1);
    public Color towerPoleColor = new Color(0, 0, 0, 1);
    public Color towerBaseColor = new Color(0, 0, 0, 1);
    public Color towerPoleInnerColor = new Color(0, 0, 0, 1);
    public Color towerBaseInnerColor = new Color(0, 0, 0, 1);
    public Color tile1 = new Color(0, 0, 0, 1);
    public Color tile2 = new Color(0, 0, 0, 1);
    public Color tile3 = new Color(0, 0, 0, 1);
    public Color tile4 = new Color(0, 0, 0, 1);
    public Color tile5 = new Color(0, 0, 0, 1);
    public Color text = new Color(0, 0, 0, 1);
}
