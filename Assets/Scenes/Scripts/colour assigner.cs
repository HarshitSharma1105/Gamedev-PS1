using UnityEngine;

public class colourassigner : MonoBehaviour
{
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    private void Start()
    {
        // Get the SpriteRenderer component attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found on this GameObject.");
        }
    }

    // Function to change the sprite's color
    public void ChangeSpriteColor(Color newColor)
    {
        if (spriteRenderer != null)
        {
            // Assign the new color to the sprite's material color
            spriteRenderer.color = newColor;
        }
    }
}
