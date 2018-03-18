using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GetPlanets : MonoBehaviour{
    int planets=0;
    string currentplanet = "";
    bool noplanets;
    public AudioClip portalsound;
    string[] planetname = {"Sun", "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
    public Text textOB1;
    public Text textOB2;
    public Image back1;
    public Image back2;
    float restartTimer;
    public float restartDelay = 3f;
    public static bool yeah;
    private float searchCountdown = 15f;

    // Use this for initialization
    void Start() {
        noplanets = false;
       

    }
	
	// Update is called once per frame
	void Update () {
      if(noplanets == true)
        {

            textOB1.text = "You proper stack the Solar System" + "\n" + "Press B Button to continue";
            textOB2.text = "You proper stack the Solar System" + "\n" + "Press B Button to continue";
            textOB1.color = Color.yellow;
            textOB2.color = Color.yellow;
            back1.color = Color.black;
            back2.color = Color.black;

            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("GameOver2");
            }
            
        }
        if (!IsPlanetThere())
        {

            back1.color = Color.clear;
            back2.color = Color.clear;
            textOB1.color = Color.clear;
            textOB2.color = Color.clear;

        }
    }


    bool IsPlanetThere()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 15f;



            if (GameObject.Find(currentplanet) == null )
            {
              
                return false;
            }
           
        }

        return true;
    }







    void OnTriggerEnter(Collider other)
    {

        if (other.name.Equals(planetname[planets])  && other.tag.Equals("Planet"))
        {

            textOB1.text = planetname[planets] + " caught!";
            textOB2.text =  planetname[planets] + " caught!";
            textOB1.color = Color.yellow;
            textOB2.color = Color.yellow;
            back1.color = Color.black;
            back2.color = Color.black;
           

            int y = GameObject.FindGameObjectsWithTag("Planet").Length;
            GameObject[] pp = GameObject.FindGameObjectsWithTag("Planet");
            for (int i = 0; i < y; i++)
            {
                if (this.name != pp[i].name)
                {

                    GameObject.Find(pp[i].name).GetComponent<DDObject>().enabled = true;
                }

            }

           
            Debug.Log(planetname[planets]);
            currentplanet = planetname[planets];
            if (planets != 9)
            {
                noplanets = false;
                planets += 1;
            }
            else
            {
                noplanets = true;
            }
            
            
            Debug.Log(planets);
            AudioSource.PlayClipAtPoint(portalsound, transform.position);
          Destroy(other.gameObject);
         


        }
        else
        {
            other.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        }

     
    }

    void OnTriggerStay(Collider other)
    {
        

        

        
        

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exitface");

    }


}
