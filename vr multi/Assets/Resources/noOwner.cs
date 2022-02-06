using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class noOwner : MonoBehaviour
{
    private PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        photonView.isRuntimeInstantiated = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
