using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    
    public Vector3 pos;
    GameObject smorkobj;
    GameObject fire;
    GameObject[] prefub=new GameObject[2];
    player playerscript;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        prefub[0] = (GameObject)Resources.Load("smork");
        prefub[1]= (GameObject)Resources.Load("fire");
        //プレハブ生成
        smorkobj =Instantiate(prefub[0], this.transform.position, Quaternion.identity);
        obj = this.gameObject;
       
      
            playerscript = obj.GetComponent<player>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
            //if (playerscript.LIVE == false)
            //{
            //    Destroy(smorkobj);
            //    playerscript.LIVE = true;
            //}
            //if (Input.GetKeyUp(KeyCode.Return))
            //{
            //    smorkobj = Instantiate(prefub[0], this.transform.position, Quaternion.identity);
            //}
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire = Instantiate(prefub[1], this.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Destroy(fire);
        }
    }
}
