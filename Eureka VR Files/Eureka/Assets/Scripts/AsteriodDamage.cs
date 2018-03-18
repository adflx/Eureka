using UnityEngine;
using System.Collections;

public class AsteriodDamage : MonoBehaviour {

    public GameObject DestroyPrefab;
    public int Damage = 50;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider Enemy)
    {
       

        if (Enemy.name == "Earth" )

        {
           
            Enemy.SendMessage("ApplyDamage", Damage, SendMessageOptions.DontRequireReceiver);
            Instantiate(DestroyPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);

        }

        else if(Enemy.name == "Player")
        {
           
            Enemy.SendMessage("ApplyDamage", Damage, SendMessageOptions.DontRequireReceiver);
        }

    }
}
