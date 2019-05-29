using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float DestroyDown;
    public bool destroyable;

    private float DestroyTimer;
    // Start is called before the first frame update
    void Start()
    {
        DestroyTimer = DestroyDown;
    }
    
    // Update is called once per frame
    void Update()
    {
        /*
        if ((DestroyTimer > 0) && destroyable)
        {
            DestroyTimer -= Time.deltaTime;
        }
        if (DestroyTimer < 0)
        {
            DestroyTimer = 0;
        }
        if (DestroyTimer == 0)
        {
            Destroy(gameObject);
        }
        */

    }
    
    IEnumerator instObj()
    {
        while (true)
        {
            if (DestroyTimer <= 0)
            {
                Destroy(gameObject);
            }
            yield return new WaitForSeconds(DestroyTimer);
            DestroyTimer -= Time.deltaTime;
        }
    }
    
}
