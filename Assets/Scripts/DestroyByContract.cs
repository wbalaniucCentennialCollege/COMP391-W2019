using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContract : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boundary")
        {
            return;
        }

        if(other.tag == "Player")
        {
            Destroy(other.gameObject);
        }

        // Debug.Log(other.gameObject.name);
        
        Destroy(other.gameObject);  // Laser
        Destroy(this.gameObject);   // Asteroid
    }
}
