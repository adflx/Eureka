using UnityEngine;
using System.Collections;

public class amove : MonoBehaviour {

    Transform track;
    public float movespeed = 3;
    GameObject trackpoint;
    int trackPos;

    void Start()
    {
        trackpoint = GameObject.FindGameObjectWithTag("Finish");   
    }


    // Update is called once per frame
    void Update()
    {

        float move = movespeed * Time.deltaTime;
        track = trackpoint.transform;
        transform.position = Vector3.MoveTowards(transform.position, track.position, move);
    }
}
