using UnityEngine;

public class Game : MonoBehaviour
{
    public Tower selectedTower = null;

    void Start()
    {

    }

    public void SelectTower(Tower newTower)
    {
        if (selectedTower == null)
        {
            selectedTower = newTower;
            return;
        }

        if (selectedTower == newTower)
        {
            selectedTower = null;
            return;
        }

        print($"Swapping Tiles! {selectedTower} to {newTower}");
        MoveTile(selectedTower, newTower);
        selectedTower = null;
    }

    public void MoveTile(Tower fromTower, Tower toTower)
    {
        Transform movedTile = fromTower.GetTopTile();
        if (movedTile == null)
        {
            return;
        }

        Transform targetTile = toTower.GetTopTile();

        if (GetComponent<RectTransform>(movedTile) < GetComponent<RectTransform>(targetTile)) // movedTile is smaller than targetTile OR targetTile is empty
        {
            movedTile.SetParent(toTower.towerAnchor);
            movedTile.SetAsFirstSibling();
        }
    }
}
