using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class near : MonoBehaviour
{
    Rigidbody2D rd; //Rigidbodyオブジェクト  //オブジェクト移動スピード
    Animator animator;
    public GameObject projectilePrefab;
    private GameObject _arrow;
    GameObject Instance;

    void Start()
    {
        rd = GetComponent<Rigidbody2D>();   //Rigidbodyコンポーネント取得
        this.animator = GetComponent<Animator>();
        Instance = GameObject.Find ("start");
    }

    void Update()    
    {
        if(Input.GetKeyDown(KeyCode.X)) {
            if (_arrow == null){
                _arrow = Instantiate(projectilePrefab,Instance.transform.position, Quaternion.identity) as GameObject;
            }
        }    //攻撃開始時(Spaceキーを押すと攻撃開始)
             //rd.velocity = new Vector2(attspeed, 0); //スピードをつけて攻撃オブジェクトを移動
        Destroy(_arrow,0.2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //animator.SetTrigger("Death");
        Destroy(_arrow,0.001f);
    }
}