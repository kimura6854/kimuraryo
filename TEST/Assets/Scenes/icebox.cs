using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icebox : MonoBehaviour
{
    GameObject obj;
    public bool Hit=false;
    // Start is called before the first frame update
    void Start()
    {

        obj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Hit)
        {
            Destroy(obj);
        }   
    }
}
