using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
    
    public Rigidbody projectile;
    public int speedAmm = 20;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.G))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(Vector3.forward * speedAmm);
            
        }
        
    }
    
    
}