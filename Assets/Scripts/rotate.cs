using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class rotate : MonoBehaviour
{
    public Vector3 _rotation;
    public float _speed = 2f;
       // public Vector3 sizeChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation*_speed*Time.deltaTime);

        // if(Input.GetKeyDown("1")){

        //  transform.localScale += sizeChange;
        // }
        
       
        
    }
}
