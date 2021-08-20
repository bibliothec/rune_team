using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    Rigidbody2D rd; //Rigidbodyオブジェクト
    float attspeed =  -80f;  //オブジェクト移動スピード
    float con = 80f;
    public Transform target;
    public Transform bullet;

    void Start()
    {
        rd = GetComponent<Rigidbody2D>();   //Rigidbodyコンポーネント取得
    }

    void Update()    
    {
        Vector3 targetPos = target.position;
        Vector3 bulletPos = bullet.position;
        if(Input.GetKeyDown(KeyCode.Z)){     //攻撃開始時(Sキーを押すと攻撃開始)
            if (targetPos.x > bulletPos.x){
                rd.velocity = new Vector2(attspeed, 0);
            }
            else{
                rd.velocity = new Vector2(con, 0);
            }
        } 
    }
}