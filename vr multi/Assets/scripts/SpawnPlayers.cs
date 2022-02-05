using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{

    private GameObject spawnedPlayerPrefab;
    public float minx;
    public float miny;
    public float maxx;
    public float maxy;


    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        spawnedPlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedPlayerPrefab);
    }



    // Start is called before the first frame update
    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
