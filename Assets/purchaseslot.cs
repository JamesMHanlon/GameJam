using UnityEngine;
using UnityEngine.UI;

public class PurchaseSlot : MonoBehaviour
{

    public ClickCounter clickCounter;
    public int ButtonValue;

    private void UpdateMoney()
    {
        clickCounter.clickCount -= ButtonValue;
    }
}
