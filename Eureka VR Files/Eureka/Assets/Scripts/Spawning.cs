using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

  public  GameObject[] spawnpoints;
    public static int waves;
    public GameObject Enemy;
 

    // Use this for initialization
    void Start () {
        spawnpoints = GameObject.FindGameObjectsWithTag("Spawn");
        waves = 0;
    }

	
	// Update is called once per frame
	void Update () {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log(enemies.Length);
        if (enemies.Length <= 5 )
            {
                InvokeRepeating("spawnEnemies", 5, 10f);
            }
       if (enemies.Length <= 10)
        {
            InvokeRepeating("spawnEnemies", 3, 10f);
        }
        if (enemies.Length <= 15 )
        {
            InvokeRepeating("spawnEnemies", 1, 10f);
        }

    }

    void spawnEnemies()
    {
        int SpawnPos = Random.Range(0, (spawnpoints.Length - 0));
        Instantiate(Enemy, spawnpoints[SpawnPos].transform.position,transform.rotation);
        Debug.Log(waves);
        waves++;
        CancelInvoke();
        
    }
}
