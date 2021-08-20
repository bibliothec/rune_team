using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Instance;
    private GameObject bul;
    public GameObject projectilePrefab;
    void Start()
    {
        Instance = GameObject.Find ("start");
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown (KeyCode.Z)) 
        {
            bul = Instantiate (projectilePrefab, Instance.transform.position, Quaternion.identity) as GameObject;
        }
        Destroy(bul,3.0f);
    }
}
