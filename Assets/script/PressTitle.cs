using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressTitle : MonoBehaviour
{
    private bool firstPush=false;

    public void OnClickButton_retry()
    {
        Debug.Log("Press Start!");
        if(!firstPush)
        {
            Debug.Log("Go Next Scene!");
            //write command to move next scene
            SceneManager.LoadScene("title");
            firstPush=true;
        }
    }
}
