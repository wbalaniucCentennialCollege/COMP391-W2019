using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContract : MonoBehaviour
{
    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boundary")
        {
            return;
        }

        if(other.tag == "Player")
        {
            // Trigger game over logic in here
            Destroy(other.gameObject);
        }

        // Debug.Log(other.gameObject.name);

        // Instantiate asteroid explosion animation
        Instantiate(explosion, this.transform.position, Quaternion.identity);

        Destroy(other.gameObject);  // Laser
        Destroy(this.gameObject);   // Asteroid
    }
}
