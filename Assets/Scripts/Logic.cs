using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//importante
using Photon.Pun;
using Photon.Realtime;



public class Logic : MonoBehaviourPunCallbacks //atento que cambia
{
    public static Logic instancia;

    private void Awake()
    {
        instancia = this;
        DontDestroyOnLoad(gameObject);//no se destruye entre scenes
    }


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }


    void Update()
    {
        
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Felicidades estas conectado");
    }
}
