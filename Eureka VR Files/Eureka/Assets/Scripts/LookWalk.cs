using UnityEngine;
using System.Collections;

public class LookWalk : MonoBehaviour {

    public float velocity = 0.7f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moveDirection = Camera.main.transform.forward;
        moveDirection *= velocity * Time.deltaTime;
       // moveDirection.y = 0.0f;
        transform.position += moveDirection;

    }
}
