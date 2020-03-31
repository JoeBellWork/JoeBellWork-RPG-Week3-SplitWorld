using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTextureSetup : MonoBehaviour
{
    public Camera cameraPortal;
    public Material cameraMat;

    // Update is called once per frame
    private void Start()
    {
        if(cameraPortal.targetTexture != null)
        {
            cameraPortal.targetTexture.Release();
        }
        cameraPortal.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMat.mainTexture = cameraPortal.targetTexture;
    }
}
