using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomMove : MonoBehaviour
{
    public GameObject obj;
    public float moveForward = 10;
    public float moveUpDown = 7;
    public float rotate = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad8))//w
        {
            obj.transform.Translate(Vector3.forward * moveForward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Keypad4))//a
        {
            obj.transform.Translate(Vector3.left * moveUpDown * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Keypad2))//s
        {
            obj.transform.Translate(Vector3.back * moveUpDown * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Keypad6))//d
        {
            obj.transform.Translate(Vector3.right * moveUpDown * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.Keypad9))
        {
            obj.transform.Rotate(Vector3.up * rotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Keypad7))
        {
            obj.transform.Rotate(Vector3.down * rotate * Time.deltaTime);
        }
        
    }
}
