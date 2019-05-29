using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public static GameObject explosion;
    public static GameObject bullet;

    private void OnCollisionEnter(Collision collision)
    {
        
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(bullet);
    }
    
    static void selfDestroy()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(bullet);
    }
}
