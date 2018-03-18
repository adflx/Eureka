using UnityEngine;
using System.Collections;

public class DDObject : MonoBehaviour, DragDropHandler
{
    string[] planetname = { "Sun", "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
    private bool IsHeld;
    private GameObject Reticle;
    // Use this for initialization
    void Start()
    {
        IsHeld = false;
        Reticle = GameObject.Find("DDReticle");
        GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHeld)
        {
            Vector3 moveDirection = transform.position;
            Ray ray = new Ray(Reticle.transform.position, Reticle.transform.forward);
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
               
                
            if (moveDirection.y < 0)
            {
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                transform.position = ray.GetPoint(2);
                moveDirection.y = 0.0f;
                
            }
            else
            {
                this.GetComponent<Rigidbody>().velocity = Vector3.zero;
                transform.position = ray.GetPoint(2);
                

            }


        }
    }

    public void HandleGazeTriggerStart()
    {
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;

        //only the object being held will enable
        int y = GameObject.FindGameObjectsWithTag("Planet").Length;
        GameObject[] pp = GameObject.FindGameObjectsWithTag("Planet");
        for (int i = 0; i < y; i++)
        {
            if(this.name != pp[i].name)
            {
                
                GameObject.Find(pp[i].name).GetComponent<DDObject>().enabled = false;
            }
            
        }
       
        IsHeld = true;
        GetPlanets.yeah = IsHeld;
        //  GetComponent<Renderer>().material.color = Color.white;
    }
    public void HandleGazeTriggerEnd()
    {
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;

        //only the object being held will enable
        int y = GameObject.FindGameObjectsWithTag("Planet").Length;
        GameObject[] pp = GameObject.FindGameObjectsWithTag("Planet");
        for (int i = 0; i < y; i++)
        {
            if (this.name != pp[i].name)
            {

                GameObject.Find(pp[i].name).GetComponent<DDObject>().enabled = true;
            }

        }




        IsHeld = false;
        
        GetPlanets.yeah = IsHeld;
    }



}
