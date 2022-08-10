using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{   
    public Vector3 sizeChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w")){
         transform.localScale += sizeChange;

        }
        if(Input.GetKeyDown("s")){
         transform.localScale -=  sizeChange;

        }
    }
}
