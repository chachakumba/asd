using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class NormalShoot : NetworkBehaviour
{
    public Weapon weapon;

    [SerializeField]
    private LayerMask mask;

    [SerializeField]
    private Camera cam;

    [SerializeField]
    private GameObject shootPoint;

    void Start()
    {
        if(cam == null)
        {
            Debug.LogError("normalShoot: No camera");
            this.enabled = false;
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Shoot();
        }
    }
    [Client]
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootPoint.transform.position, shootPoint.transform.forward, out hit, weapon.range, mask))
        {
            print("we shooted " + hit.collider.name);
            if (hit.collider.tag == "Player")
                CmdShoot(hit.collider.name);
        }
    }

    [Command]
    void CmdShoot(string ID)
    {
        Debug.Log(ID + " has been shooted");
        MyPlayer player = MyGameManager.FindPlayer(ID);
        Debug.Log(player.transform.name + "from shoot");
        player.GetDamage(1);
    }
}
