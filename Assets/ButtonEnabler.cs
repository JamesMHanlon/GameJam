using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabler : MonoBehaviour
{
    public Button button1; // Button that is enabled when clickCount > 100
    public Button button2; // Button that is enabled when clickCount > 500
    public Button button3; // Button that is enabled when clickCount > 1000

    public ClickCounter clickCounter; // Reference to the ClickCounter script

    private void Start()
    {
        // Set the initial state of buttons based on the current clickCount
        UpdateButtonStates();
    }

    private void Update()
    {
        // Update the button states periodically
        UpdateButtonStates();
    }

    private void UpdateButtonStates()
    {
        // Enable or disable each button based on the clickCount value
        if (clickCounter != null)
        {
            button1.interactable = clickCounter.clickCount >= 100;
            button2.interactable = clickCounter.clickCount >= 500;
            button3.interactable = clickCounter.clickCount >= 1000;
        }
    }
}
