using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSelectionMenu : MonoBehaviour
{
    public GameObject PopUpBox;
    public Animator animator;

    public void PopUp(){
        PopUpBox.SetActive(true);
        animator.SetTrigger("pop");
    }
}
