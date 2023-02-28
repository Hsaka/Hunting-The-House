using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController : MonoBehaviour
{
    public GameObject Pubbles;
    public GameObject Almond;
    public ARRaycastManager RaycastManager;

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();
            RaycastManager.Raycast(Input.GetTouch(0).position,touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

            if (touches.Count % 2 == 0)
            {
                GameObject.Instantiate(Pubbles, touches[0].pose.position, touches[0].pose.rotation);
            }
            else
            {
                GameObject.Instantiate(Almond, touches[0].pose.position, touches[0].pose.rotation);
            }
        } 
        
    }
}
