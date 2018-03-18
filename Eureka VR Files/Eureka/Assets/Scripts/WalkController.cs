using UnityEngine;
using System.Collections;

public class WalkController : MonoBehaviour {

   
    public float velocity;
 //   public GameObject header;

    // Use this for initialization
    void Start () {
     
        
	}
	
	// Update is called once per frame
	void Update () {
        //float x = Input.gyro.rotationRate.x;
        //float y = Input.gyro.rotationRate.y;
        //Debug.Log(y);
        //   transform.RotateAround(transform.position, transform.right, -x * Time.deltaTime * 5f);
        //  transform.RotateAround(transform.position, Vector3.up, -y * Time.deltaTime * 5f);
        //transform.rotation = Quaternion.Euler(0, header.GetComponent<GvrHead>().rott.eulerAngles.y , 0f);
       /// transform.localRotation = Quaternion.Euler(0, header.gameObject.transform.forward.x, 0f);
        // transform.Rotate(header.gameObject.transform.localEulerAngles.x * Time.deltaTime, header.gameObject.transform.localEulerAngles.y * Time.deltaTime, 0f);

        transform.Translate(velocity * Input.GetAxis("Horizontal") * Time.deltaTime,0f, velocity* Input.GetAxis("Vertical") * Time.deltaTime);
        
      //  GetComponent<Rigidbody>().velocity = Vector3.zero;

    }
}
