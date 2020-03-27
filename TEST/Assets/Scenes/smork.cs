using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smork : MonoBehaviour
{
    Vector3 pos;
    GameObject player;
   public string objname;
    // Start is called before the first frame update
    void Start()
    {
        //煙を付けたいオブジェクト参照
        player = GameObject.Find(objname);
    }


    // Update is called once per frame
    void Update()
    {
        Transform mytransform = this.transform;
        pos = player.transform.position;
        mytransform.position = pos;
        mytransform.rotation = Quaternion.Euler(270.0f, 0, 0);
    }
}
