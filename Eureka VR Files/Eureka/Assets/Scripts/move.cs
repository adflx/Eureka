using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public static Transform bulletsp;
    Transform track;
    public float movespeed;
    public GameObject[] trackpoints;
    int trackPos;

    private float searchCountdown = 5f;
    

    void Start()
    {
        
        trackpoints = GameObject.FindGameObjectsWithTag("Track");
        trackPos = Random.Range(0, trackpoints.Length);
        bulletsp = trackpoints[trackPos].transform.GetChild(0);
    }


    // Update is called once per frame
    void Update () {
        
        float move = movespeed * Time.deltaTime;
        track = trackpoints[trackPos].transform;
        transform.position = Vector3.MoveTowards(transform.position, track.position, move);

        if (shipMovement() == true)
        {
            trackPos = Random.Range(0, (trackpoints.Length - 0));
            bulletsp = trackpoints[trackPos].transform.GetChild(0);
            transform.position = Vector3.MoveTowards(transform.position, track.position, move);

        }
    }


    bool shipMovement()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 5f;
            return true;
         

            
        }

        return false;
    }

    


}
