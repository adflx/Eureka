using UnityEngine;
using System.Collections;

public class GunBoss : MonoBehaviour {

    public GameObject Bullet;
    Transform BulletSpawn;
    public AudioClip GunSound;
    public float NextFire;
    public float FireRate;
    public GameObject[] targets;
    int tarpos;
    Transform target;

    private float mothercountdown = 10f;

    // Use this for initialization
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
        tarpos = Random.Range(0, (targets.Length - 0));
        target = targets[tarpos].transform;
        bmove.bulletsp.transform.LookAt(target);
        BulletSpawn = bmove.bulletsp;
    }

    // Update is called once per frame
    void Update()
    {

        if (mothershipmovement() == true)
        {
            tarpos = Random.Range(0, (targets.Length - 0));
            target = targets[tarpos].transform;

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

    void OnTriggerStay(Collider ship)
    {
        //this.transform.LookAt(target);
        if (Time.time > NextFire & ship.tag == "Track")
        {
            bmove.bulletsp.transform.LookAt(target);
            Instantiate(Bullet, bmove.bulletsp.transform.position, bmove.bulletsp.transform.rotation);
            AudioSource.PlayClipAtPoint(GunSound, transform.position);
            NextFire = Time.time + FireRate;
        }



    }
}
