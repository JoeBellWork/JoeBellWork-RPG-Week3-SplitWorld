using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCam;
    public Transform portal, otherPortal;


    private void Update()
    {
        //Sebastian League portal rotation
        //Matrix4x4 m = portal.localToWorldMatrix * otherPortal.worldToLocalMatrix * playerCam.localToWorldMatrix;
        //this.transform.SetPositionAndRotation(m.GetColumn(3), m.rotation);



        // Brackey portal rotation
        //Vector3 playerOffSetFromPortal = playerCam.position - otherPortal.position;
        //transform.position = portal.position + playerOffSetFromPortal;

        //float angularDifference = Quaternion.Angle(portal.rotation, otherPortal.rotation);
        //Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifference, Vector3.up);

        //Vector3 newCameraDirection = portalRotationalDifference * playerCam.forward;
        //transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
