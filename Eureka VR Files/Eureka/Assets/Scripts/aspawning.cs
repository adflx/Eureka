using UnityEngine;
using System.Collections;

public class aspawning : MonoBehaviour {
    public GameObject spawnpoint;
    public GameObject[] asteriod ;

    // Use this for initialization
    void Start () {
        spawnpoint = GameObject.Find("asteriodspawnarea");
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] aster;
        aster = GameObject.FindGameObjectsWithTag("Asteriod");
        if (aster.Length <= 2)
        {
            InvokeRepeating("spawnaster", 5, 5f);
        }
    }

    void spawnaster()
    {
        int asterr= Random.Range(0, (asteriod.Length - 0));
        Instantiate(asteriod[asterr], spawnpoint.transform.position, transform.rotation);

        CancelInvoke();
    }
}
