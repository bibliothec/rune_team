using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressStart : MonoBehaviour
{
    private bool firstPush=false;

    public void OnClickPressStart()
    {
        Debug.Log("Press Start!");
        if(!firstPush)
        {
            Debug.Log("Go Next Scene!");
            //write command to move next scene
            SceneManager.LoadScene("play");
            firstPush=true;
        }
    }
}
