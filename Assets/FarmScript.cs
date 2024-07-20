using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmScript : MonoBehaviour
{
    public void ExitFarm()
    {
        Debug.Log("ExitingFarm_EnteringDungeon");
        SceneManager.LoadScene("Dungeon");
    }
}
