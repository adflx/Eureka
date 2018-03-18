using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class EarthHealthBar : MonoBehaviour {


    public Image currenthealthbar1;
    public Text ratiotext1;
    public Image currenthealthbar2;
    public Text ratiotext2;

    private float hitpoint = 8000;
    private float maxhitpoint = 8000;

    float restartTimer;
    public float restartDelay = 3f;

    public Image gameoverback1;
    public Text gameovertext1;
    public Image gameoverback2;
    public Text gameovertext2;

    // Use this for initialization
    void Start () {
        UpdateHealthBar();
    
      
    }
	
	// Update is called once per frame
	void Update () {
        if (hitpoint == 0)
        {
            Time.timeScale = 0;
            gameoverback1.color = Color.black;
            gameoverback2.color = Color.black;
            gameovertext1.color = Color.white;
            gameovertext2.color = Color.white;
            

            if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    private void UpdateHealthBar()
    {
        float ratio = hitpoint / maxhitpoint;
        currenthealthbar1.rectTransform.localScale = new Vector3(ratio, 1, 1);
        currenthealthbar2.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratiotext1.text = (ratio * 100).ToString("0") + '%';
        ratiotext2.text = (ratio * 100).ToString("0") + '%';

        if((ratio *100) <=20 & (ratio*100)>10)
        {
            currenthealthbar1.color = Color.yellow;
            currenthealthbar2.color = Color.yellow;

        }
        else if((ratio * 100) <= 10)
        {
            currenthealthbar1.color = Color.red;
            currenthealthbar2.color = Color.red;
        }
    }

    void ApplyDamage(int Damage)

    {
        hitpoint -= Damage;
        

        
        if (hitpoint <= 0)

        {
            hitpoint = 0;
            Debug.Log("DEAD");
        }

        UpdateHealthBar();

    }

}
