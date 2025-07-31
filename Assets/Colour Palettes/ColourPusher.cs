using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColourPusher : MonoBehaviour
{
    public Image[] towerPoles;
    public Image[] towerBases;
    public Image[] towerPolesInner;
    public Image[] towerBasesInner;
    public Image tile1, tile2, tile3, tile4, tile5;
    public TMP_Text text;

    public ColorPalette defaultPalette;

    // Apply the new palette to all of the relevant gameObjects when I change the property
    private ColorPalette currentPalette;
    public ColorPalette currentPalette_prop
    {
        get
        {
            return currentPalette;
        }

        set
        {
            currentPalette = value;
            Camera.main.backgroundColor = currentPalette.backgroundColor;
            tile1.color = currentPalette.tile1;
            tile2.color = currentPalette.tile2;
            tile3.color = currentPalette.tile3;
            tile4.color = currentPalette.tile4;
            tile5.color = currentPalette.tile5;
            text.color = currentPalette.text;

            foreach (Image eachImage in towerPoles)
            {
                eachImage.color = currentPalette.towerPoleColor;
            }

            foreach (Image eachImage in towerPolesInner)
            {
                eachImage.color = currentPalette.towerPoleInnerColor;
            }

            foreach (Image eachImage in towerBases)
            {
                eachImage.color = currentPalette.towerBaseColor;
            }

            foreach (Image eachImage in towerBasesInner)
            {
                eachImage.color = currentPalette.towerBaseInnerColor;
            }
        }
    }

    void Start()
    {
        currentPalette_prop = defaultPalette;
    }
}
