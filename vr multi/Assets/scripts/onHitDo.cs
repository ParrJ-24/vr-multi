using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHitDo : MonoBehaviour
{
    public Vector3 location;
    public Rigidbody target;
    // Start is called before the first frame update
    void Start()
    {
       // target = GameObject.Find("target1").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            target.transform.position = location;
        }
    }

}
