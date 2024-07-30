using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purchaseslot : MonoBehaviour
{
    public ClickCounter clickCounter;
    public int value;

    private void OnClickDown()
    {
        clickCounter.DecreaseClickCount(value);
    }
}
