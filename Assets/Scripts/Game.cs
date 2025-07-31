using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    // selectedTower will select/deselect (null) a Tower button presses
    public Tower selectedTower = null;
    public Color selectedColor = new Color(0, 0, 0, 1);

    public TMP_Text turnCounterDisplay;
    // Properties - getters and setters to implement numerous actions when a variable is changed, in this case update a UI field when turnCounter is changed
    private int turnCounter;
    public int turnCounter_prop
    {
        get { return turnCounter; }
        set
        {
            turnCounter = value;
            turnCounterDisplay.text = "Moves: " + turnCounter.ToString();
        }
    }

    void Start()
    {
        turnCounter_prop = 0;
    }

    /// <summary>
    /// Implements 'newTower' as the selectdTower
    /// If it was already selected, deselect
    /// If there's already a selected tower, perform MoveTile()
    /// </summary>
    /// <param name="newTower"></param>
    public void SelectTower(Tower newTower)
    {
        if (selectedTower == null)
        {
            selectedTower = newTower;
            selectedTower.AssignColor(selectedColor);
            return;
        }

        if (selectedTower == newTower)
        {
            selectedTower.AssignColor(GetComponent<ColourPusher>().currentPalette_prop.towerPoleColor);
            selectedTower = null;
            return;
        }

        //print($"Swapping Tiles! {selectedTower} to {newTower}");
        MoveTile(selectedTower, newTower);
        selectedTower.AssignColor(GetComponent<ColourPusher>().currentPalette_prop.towerPoleColor);
        selectedTower = null;
    }

    /// <summary>
    /// Move the top most tile from 'fromTower' to 'toTower'
    /// But only if movedTile is smaller than the targetTile
    /// </summary>
    /// <param name="fromTower"></param>
    /// <param name="toTower"></param>
    public void MoveTile(Tower fromTower, Tower toTower)
    {
        RectTransform movedTile = fromTower.GetTopTile();
        if (movedTile == null)
        {
            return;
        }

        RectTransform targetTile = toTower.GetTopTile();

        if (targetTile == null || movedTile.rect.width < targetTile.rect.width)
        {
            movedTile.SetParent(toTower.towerAnchor);
            movedTile.SetAsFirstSibling();
            turnCounter_prop += 1;
        }
    }

}
