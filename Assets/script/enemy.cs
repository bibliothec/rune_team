using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public float gravity;
    public bool nonVisibleAct;

    //private Rigidbody2D rb=null;
    //private SpriteRenderer sr=null;
    //private bool rightTleftF=false;
    public  int hp=50;

    //// Start is called before the first frame update
    //void Start()
    //{
        //rb=GetComponent<Rigidbody2D>();
        //sr=GetComponent<SpriteRenderer>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
        //if(sr.isVisible||nonVisibleAct){
            //int xVector=-1;
            //if(rightTleftF){
                //xVector=1;
                //transform.localScale=new Vector3(-1,1,1);
            //}else{
                //transform.localScale=new Vector3(1,1,1);
            //}
            //rb.v50ocity=new Vector2(xVector*speed,-gravity);
        //}else{
            //rb.Sleep();
        //}



    //}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("attack"))
        {
                hp-=10;
                if(hp<=0){
                    Destroy(this.gameObject);
                }
        }
    }
}
