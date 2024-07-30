using UnityEngine;
using TMPro;

public class ClickCounter : MonoBehaviour
{
    public TMP_Text clickTextUI;
    public int clickCount;

    public void IncrementClickCount(int value)
    {
        clickCount += value;
        UpdateClickCountText();
    }

    public void DecreaseClickCount(int Purchase)
    {
        clickCount -= Purchase;
        UpdateClickCountText();
    }

    private void UpdateClickCountText()
    {
        clickTextUI.text = "£: " + clickCount;
    }
}
