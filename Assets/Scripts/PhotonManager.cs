using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();//verifica archivos y coneccta al servidor
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()//unirse a un servidos, si no hay lo crea
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 2 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()//cuando nos unamos al room
    {
        PhotonNetwork.Instantiate("Player", new Vector2(Random.Range(-3,4), 2), Quaternion.identity);
    }
}
