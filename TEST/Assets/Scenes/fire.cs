using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    GameObject[] iceobj;
    GameObject player;
   // player playerscript;
    GameObject fireobj;
    icebox icescript,d;
    
    public string Effectname;
    float lenge;
    // Start is called before the first frame update
    void Start()
    {
     
        iceobj = new GameObject[1];
        lenge = 13.0f;
       // iceobj[0] = GameObject.Find("Plane");//ここを複数読み込めるようにするPlane[1,2,3]みたいに,icebox次第
       // icescript = iceobj[0].GetComponent<icebox>();
        fireobj = this.gameObject;
        player = GameObject.Find("Cube");
      //  playerscript = player.GetComponent<player>();
    }
    void Update()
    {
       
        Transform mytransform = this.transform;
 
        mytransform.rotation=Quaternion.Euler(0,90.0f,0);
        mytransform.position = player.transform.position;
        //ここにプレイヤー向きステータスでifとる、上下左右4パターン作る
        //if (icescript.Hit != true)
        //{
        //    if (fireobj.transform.position.x + lenge >= iceobj[0].transform.position.x&&
        //        fireobj.transform.position.x< iceobj[0].transform.position.x//&&
        //        //fireobj.transform.position.y== iceobj[0].transform.position.y
        //        )
        //    {
        //        icescript.Hit = true;
        //    }
        //}
    }

}
