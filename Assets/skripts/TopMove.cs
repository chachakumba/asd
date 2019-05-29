using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopMove : MonoBehaviour
{
    public GameObject obj;
    public float sensitiveX = 3;
    public float sensitiveY = 3;
    
    public float maxY = 120;
    public float minY = 80;
    
    private float rotX = 0;
    private float rotY = 90;

    void Start()
    {
        
    }
    

    void Update()
    {

        rotX += Input.GetAxis("Mouse X") * sensitiveX;
        rotY += Input.GetAxis("Mouse Y") * sensitiveY;


        rotX %= 360;
        
        if (rotY < minY)
        {
            rotY = minY;
        }

        if (rotY > maxY)
        {
            rotY = maxY;
        }
        
        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotY, Vector3.left);

        obj.transform.localRotation = xQuaternion * yQuaternion;
        

    }
}
