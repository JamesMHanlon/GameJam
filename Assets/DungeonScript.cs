using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DungeonScript : MonoBehaviour
{
    public void OnMouseDown ()
    {
        // CHECK
        Debug.Log("EnteringFarm");
        SceneManager.LoadScene("Farm");
    }

}
