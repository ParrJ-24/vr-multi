using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class DoorBell : MonoBehaviourPunCallbacks
{

    public Rigidbody EntryBlock;
    public Vector3 SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnJoinedRoom()
    {
        Rigidbody clone = Instantiate(EntryBlock, SpawnPoint, transform.rotation) as Rigidbody;
        Debug.Log("playerjoined");
        base.OnJoinedRoom();
    }

}
