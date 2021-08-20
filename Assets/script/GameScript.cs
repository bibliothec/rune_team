using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
                image.fillAmount-=0.1f;
        }
         if (other.gameObject.CompareTag("goal"))
        {
                SceneManager.LoadScene("clear");
        }
    }


    // Update is called once per frame
    void Update()
    {
        Transform mytransform=this.transform;
        Vector3 pos=mytransform.position;

        if(image.fillAmount==0||pos.y<-280f){
            Debug.Log("game over");
            SceneManager.LoadScene("gameover");
        }
    }
}
