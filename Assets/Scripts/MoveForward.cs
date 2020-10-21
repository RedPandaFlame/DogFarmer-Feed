using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PROTOTYPE 2

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
