using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    //生成するゲームオブジェクト
    public GameObject bullet1;
    public float bulletSpeed = 1f;
    void Update()
    {
    if (Input.GetKeyDown("enter"))
        {
            GameObject runcherBullet = GameObject.Instantiate(bullet1) as GameObject; //runcherbulletにbulletのインスタンスを格納
            runcherBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed; //アタッチしているオブジェクトの前方にbullet speedの速さで発射
            runcherBullet.transform.position = transform.position;
        }
    }
}