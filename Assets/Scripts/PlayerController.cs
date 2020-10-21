using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PROTOTYPE 2

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    private float speed = 10.0f;
    private float xRange = 11f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        // Moving left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
      
        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))    // Input.GetKey works only for keyboard, if we want to launch our game on diffrent device we should use Input.GetButton and re-map it in Unity?
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            // what object to copy / where to put it / at what angle?

        }
    }
}
