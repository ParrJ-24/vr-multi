using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class NetworkPlayer : MonoBehaviour
{
    public Transform Head;
    public Transform LHand;
    public Transform RHand;
    private PhotonView photonView;
    GameObject centerEye;
    Vector3 headsetPos;
    Vector3 headsetRot;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        centerEye = GameObject.Find("CenterEyeAnchor");
    }

    // Update is called once per frame
    void Update()
    {

        if (photonView.IsMine)
        {
            Head.gameObject.SetActive(false);
            LHand.gameObject.SetActive(false);
            RHand.gameObject.SetActive(false);

            LHand.position = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
            LHand.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
            RHand.position = OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
            RHand.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);
            headsetPos = centerEye.transform.position;
            Head.transform.rotation = centerEye.transform.rotation;
        }
        //mapPosition(Head);
        

    }
    /*
    void mapPosition(Transform target,node)
    {
        

         OVRPose tracker = OVRManager.tracker.GetPose();
         Head.transform.position = tracker.position;
         Head.transform.rotation = tracker.rotation;
         

        Head.localPosition = OVRPlugin.position;
        OVRPlugin.GetNodePose(OVRPlugin.Node.TrackerThree, OVRPlugin.Step.Render).ToOVRPose();
        OVRPlugin.position
        


    } */

}
