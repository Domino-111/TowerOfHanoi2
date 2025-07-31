using UnityEngine;
using UnityEngine.UI;

public class Tower : MonoBehaviour
{
    public RectTransform towerAnchor;
    public Image towerBase, towerPole;

    /// <summary>
    /// Return the first child if any
    /// Null if not
    /// </summary>
    /// <returns></returns>
    public RectTransform GetTopTile()
    {
        return towerAnchor.childCount > 0 ? towerAnchor.GetChild(0).GetComponent<RectTransform>() : null;
    }

    /// <summary>
    /// Take a colour and apply to the tower's base and pole
    /// </summary>
    /// <param name="newColor"></param>
    public void AssignColor(Color newColor)
    {
        towerBase.color = newColor;
        towerPole.color = newColor;
    }
}
