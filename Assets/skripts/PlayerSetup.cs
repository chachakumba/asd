using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

[RequireComponent(typeof (MyPlayer))]
public class PlayerSetup : NetworkBehaviour
{
    private Camera sceneCamera;
    [SerializeField]
    public Behaviour[] componentsToDisable;

    private void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
            gameObject.layer = LayerMask.NameToLayer("NonLocalPlayer");
        }
        else
        {
            sceneCamera = Camera.main;
        }
        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(false);
        }

        transform.name = "Player " + GetComponent<NetworkIdentity>().netId;
    }
    void OnDisable()
    {
            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(true);
            }
        MyGameManager.UnRegisterPlayer(transform.name);
    }

    public override void OnStartClient()
    {
        base.OnStartClient();
        string net_Id = GetComponent<NetworkIdentity>().netId.ToString();
        MyPlayer player = GetComponent<MyPlayer>();
        Debug.Log(player.transform.name + "connected");
        print(player.transform.name + "connected");
        MyGameManager.RegisterPlayer(net_Id, player);
    }

}
