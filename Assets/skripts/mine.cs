using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mine : MonoBehaviour
{
    public int hp = 100 , damage = 50;
    public GameObject player;
    public Text text;

    void Start()
    {
        text = GameObject.Find("hpui").GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        hp -= damage;
        text.text = "HP: " + hp.ToString();
        if (hp <= 0)
        {
            Destroy(player);
        }
    }
    private void Update()
    {
        
    }
}
