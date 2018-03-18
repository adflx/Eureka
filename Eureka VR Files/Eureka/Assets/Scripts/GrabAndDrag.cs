using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GrabAndDrag : MonoBehaviour {

    private GameObject Reticle;
    GameObject grabbedObject;
    float grabbedObjectSize;
    // Use this for initialization
    void Start () {
        Reticle = GameObject.Find("GvrReticle");
    }

    GameObject GetReticleHoverObject(float range)
    {
        Vector3 position = gameObject.transform.position;
        RaycastHit raycastHit;
      
        Vector3 target = position+Camera.main.transform.forward*range;
        if (Physics.Linecast(position, target,out raycastHit))
        {
            return raycastHit.collider.gameObject;
        }
        return null;
    }

    //GameObject GetMouseHoverObject(float range)
    //{
    //    Vector3 position = gameObject.transform.position;
    //    RaycastHit raycastHit;

    //    Vector3 target = position + Camera.main.transform.forward * range;
    //    if (Physics.Linecast(position, target, out raycastHit))
    //    {
    //        return raycastHit.collider.gameObject;
    //    }
    //    return null;
    //}

    void TryGrabObject(GameObject grabObject)
    {
        if (grabbedObject==null || !CanGrab(grabObject))
        {
            return;
        }
        grabbedObject = grabObject;
        grabbedObjectSize = grabObject.GetComponent<Renderer>().bounds.size.magnitude; 
    }

    bool CanGrab(GameObject candidate)
    {
        return grabbedObject.GetComponent<Rigidbody>() != null;
    }

   void DropObject()
    {
        if (grabbedObject == null)
        {
            return;
        }
         if (grabbedObject.GetComponent<Rigidbody>() != null)
        {
            grabbedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        grabbedObject = null;
    }

	// Update is called once per frame
	void Update () {

        Debug.Log(GetReticleHoverObject(10));
        if (Input.GetMouseButton(0)){
            if (grabbedObject == null)
            {
                TryGrabObject(GetReticleHoverObject(100));
            }
            else
            {
                DropObject();
            }
        }

        if (grabbedObject != null)
        {
            Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * grabbedObjectSize;
            grabbedObject.transform.position = newPosition;
        }

        
	}
}
