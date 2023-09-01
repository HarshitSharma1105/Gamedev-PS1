using UnityEngine;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour
{
    public colourassigner colorAssigner,c1; // Reference to the ColorAssigner script
    public Button[] colorButtons; // Array of color buttons
    public Button randomColorButton; // Reference to the random color button
    public string[] a;
    private Color[] availableColors; // Array of available colors

    private void Start()
    {
        // Initialize the available colors array
        availableColors = new Color[]
        {
            HexToColor(a[0]),
            HexToColor(a[1]),
            HexToColor(a[2]),
            HexToColor(a[3]),
            HexToColor(a[4]),
            HexToColor(a[5]),
            // Add more colors as needed
        };

        // Attach button click listeners
        for (int i = 0; i < colorButtons.Length; i++)
        {
            int index = i; // Create a local copy of the index to avoid a closure issue
            colorButtons[i].onClick.AddListener(() => OnColorButtonClick(index));
        }

        // Attach a click listener to the random color button
        if (randomColorButton != null)
        {
            randomColorButton.onClick.AddListener(SelectRandomColor);
        }
    }

    // Function to handle button click events for color buttons
    private void OnColorButtonClick(int colorIndex)
    {
        if (colorAssigner != null)
        {
            // Check if the colorIndex is within the bounds of the availableColors array
            if (colorIndex >= 0 && colorIndex < availableColors.Length)
            {
                // Change the sprite's color using the ColorAssigner script
                colorAssigner.ChangeSpriteColor(availableColors[colorIndex]);
                c1.ChangeSpriteColor(availableColors[colorIndex]);
            }
            else
            {
                Debug.LogError("Invalid color index: " + colorIndex);
            }
        }
        else
        {
            Debug.LogError("ColorAssigner reference is not set.");
        }
    }

    // Function to handle the random color button click event
    private void SelectRandomColor()
    {
        if (colorAssigner != null)
        {
            // Select a random color from the availableColors array
            Color randomColor = availableColors[Random.Range(0, availableColors.Length)];

            // Change the sprite's color using the ColorAssigner script
            colorAssigner.ChangeSpriteColor(randomColor);
            c1.ChangeSpriteColor(randomColor);
        }
        else
        {
            Debug.LogError("ColorAssigner reference is not set.");
        }
    }
    private Color HexToColor(string hex)
    {
        Color color = new Color();
        ColorUtility.TryParseHtmlString(hex, out color);
        return color;
    }
}
