using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
    }
    
    void selfDestroy()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    IEnumerator shootRange()
    {
        yield return new WaitForSeconds(3);
        selfDestroy();
    }

    private void Start()
    {
        StartCoroutine(shootRange());
    }
}
