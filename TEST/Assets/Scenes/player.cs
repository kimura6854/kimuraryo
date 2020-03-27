using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Vector3 pos;
    public bool LIVE=true;
    GameObject maincamera;
    AudioScript audioscript;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = GameObject.Find("Main Camera");
        audioscript = maincamera.GetComponent<AudioScript>();
        pos.x = -20.0f;
        pos.y = 0;
        pos.z=0;
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤー移動
        Transform playertransform=this.transform;
        if (Input.GetKey(KeyCode.W))
        {
            pos.z+=0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.z -= 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += 0.1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.1f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            LIVE = false;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            //鳴らしたいSE名入力
            audioscript.playBGM("se001");
        }
        playertransform.position = pos;

    }
}
