using UnityEngine;
using System.Collections;

public class Looking : MonoBehaviour {

    public float lookSensitivity = 5f;
    public float xRotation;
    public float yRotation;
    public float currentXRotation;
    public float currentYRotation;
    public float xRotationV;
    public float yRotationV;
    public float lookSmoothDamp = 1.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
        yRotation += Input.GetAxis("Mouse X") * lookSensitivity;

        currentXRotation = Mathf.SmoothDamp(currentXRotation, xRotation, ref xRotationV, lookSensitivity);
        currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref yRotationV, lookSensitivity);


        transform.rotation = Quaternion.Euler(currentXRotation, currentYRotation, 0);

    }


}
