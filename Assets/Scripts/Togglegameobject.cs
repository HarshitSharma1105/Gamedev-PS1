using UnityEngine;
using UnityEngine.UI;

public class Togglegameobject : MonoBehaviour
{
    public GameObject targetGameObject;
    bool val=false;

    private void Start()
    {
        // Ensure the targetGameObject is initially set to the desired active state
        targetGameObject.SetActive(false);
    }

    public void ToggleActiveState()
    {
        // Toggle the active state of the targetGameObject
        targetGameObject.SetActive(!val);
        val=true;
    }
}
