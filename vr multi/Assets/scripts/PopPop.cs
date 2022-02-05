using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopPop : MonoBehaviour
{
public Rigidbody Ball;
public float velocity = 50;
public bool isRightHand = true; 
bool fire = false;

void start(){

}

void Update(){

float triggerLeft = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
float triggerRight = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);


if (this.isRightHand == true){
            if (triggerRight > 0.9f && this.fire == false)
            {
                this.fire = true;
                Rigidbody clone = Instantiate(Ball, transform.position, transform.rotation) as Rigidbody;
                clone.velocity = transform.TransformDirection(new Vector3(0, 0, velocity));
                Destroy(clone.gameObject, 3);
            }
                if (this.fire == true && triggerRight < 0.1f){ this.fire = false;}
                
        }
 
    if(this.isRightHand == false){

        if (triggerLeft > 0.9f && this.fire == false)
        {
            this.fire = true;
            Rigidbody clone = Instantiate(Ball, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(new Vector3(0, 0, velocity));
            Destroy(clone.gameObject, 3);
        }
        if (this.fire == true && triggerLeft < 0.1f) { this.fire = false; }
    }


    }
}