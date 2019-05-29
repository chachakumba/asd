using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPlayer : MonoBehaviour
{
    public int hp = 100;
    public GameObject player;
    public Text text;

    void Start()
    {
        text = GameObject.Find("hpui").GetComponent<Text>();
    }
    

    public void GetDamage(int damage)
    {
        this.hp -= damage;
        text.text = "HP: " + hp.ToString();
        if (hp <= 0)
        {
            Destroy(player);
        }
    }
    
}
