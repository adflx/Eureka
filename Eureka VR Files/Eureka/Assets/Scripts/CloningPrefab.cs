using UnityEngine;
using System.Collections;

public class CloningPrefab : MonoBehaviour {

    public GameObject CloningPreFab;
    GameObject PrefabClone;

    // Use this for initialization
    void Start () {
        for(int x = 0; x < 7; x++)
        {
            PrefabClone = Instantiate(CloningPreFab, transform.position, Quaternion.identity) as GameObject;
            PrefabClone.name = CloningPreFab.name+ x;
        }
      

    }

    


	// Update is called once per frame
	void Update () {
	
	}
}
