using UnityEngine;
using System.Collections;

public class bmove : MonoBehaviour {

public static Transform bulletsp;
    Transform track;
    public float movespeed;
    public GameObject[] trackpoints;
    int trackPos;
    
    private float mothercountdown = 10f;

    void Start()
    {
        
        trackpoints = GameObject.FindGameObjectsWithTag("Track");
        trackPos = Random.Range(0, (trackpoints.Length - 0));
        bulletsp = trackpoints[trackPos].transform.GetChild(0);
    }


    // Update is called once per frame
    void Update () {
        
        float move = movespeed * Time.deltaTime;
        track = trackpoints[trackPos].transform;
        transform.position = Vector3.MoveTowards(transform.position, track.position, move);

        if (mothershipmovement() == true)
        {
            trackPos = Random.Range(0, (trackpoints.Length - 0));
            bulletsp = trackpoints[trackPos].transform.GetChild(0);
            transform.position = Vector3.MoveTowards(transform.position, track.position, move);

        }

    }

     
bool mothershipmovement()
    {
       mothercountdown -= Time.deltaTime;
        if (mothercountdown <= 0f)
        {
            mothercountdown = 10f;
            return true;
        }
        return false;

    }


}
