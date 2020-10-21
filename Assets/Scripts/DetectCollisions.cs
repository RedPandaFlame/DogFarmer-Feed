using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PROTOTYPE 2

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
