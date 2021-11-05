using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetwork : MonoBehaviour
{
    public MonoBehaviour[] codeIgnored;

    private PhotonView photonView;


    void Start()
    {
        photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)//si no es mio
        {
            foreach (var code in codeIgnored)
            {
                code.enabled = false;//lo inhabilita
            }
        }
    }
}
