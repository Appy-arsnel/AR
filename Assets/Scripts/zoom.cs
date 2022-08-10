using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    public GameObject gameobject;
    public Vector3 sizeChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //increase_decrease(Input.GetAxis("Mouse"))
    }
     void increase_decrease()
    {
        gameobject.transform.localScale = gameobject.transform.localScale - sizeChange;    
    }
}
