using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionmenuselect : MonoBehaviour
{
    public GameObject PotionSlot;

    void OnMouseDown()
    {
        PotionSlot.SetActive(true);
    }
    
}
