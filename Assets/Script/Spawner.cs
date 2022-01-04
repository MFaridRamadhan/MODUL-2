using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject Fireball = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            Rigidbody rb = Fireball.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * 25;
        }
            
    }

}
