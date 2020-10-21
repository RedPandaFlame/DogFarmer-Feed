using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float timespawn_old = 0f;
    float timespawn_new = 5f;
    // Update is called once per frame
    void Update()
    {
         timespawn_new = Time.time;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Debug.Log("timespwan new:" + timespawn_new);

            if ( timespawn_new - timespawn_old > 0.5f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timespawn_old = timespawn_new;
            }
  
        }
        Debug.Log("timespwan old:" + timespawn_old);
        Debug.Log("timespwan new:" + timespawn_new);

    }
}
