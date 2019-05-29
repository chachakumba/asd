using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    private static Dictionary<string, MyPlayer> players = new Dictionary<string, MyPlayer>();

    private const string player_Id = "Player ";

    public static void RegisterPlayer(string id, MyPlayer p1)
    {
        string playerId = player_Id + id;
        p1.transform.name = playerId;
        players.Add(playerId, p1);
        
    }

    public static void UnRegisterPlayer(string id)
    {
        players.Remove(id);
    }

    public static MyPlayer FindPlayer(string id)
    {
        Debug.Log(players[id].transform.name + "from find");
        return players[id];
    }

    
}
