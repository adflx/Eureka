using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class InteractiveObject : MonoBehaviour {

    public bool interactionEnabled = true;

    public float distance = 5;

    public float maxGazeTime = 3;

    public float outlineWidth = 0.005f;

    public float outlineGrowSpeed = 3f;


    private Collider myCollider;

    private Transform playerTransform;

    private EventTrigger myTrigger;

    private GameObject outlineObject;

    private MeshRenderer outlineRenderer;

    private Material outlineMaterial;

    private int outlineStatus;

    private bool disableOnOutlineDestroy;

    private float outlineLerp;

    private float currentOutlineWidth;

    private float timer = 0;

    private bool isGazeAt = false;



	// Use this for initialization
	void Start () {
        outlineMaterial = Resources.Load("Materials/OutlineOnly") as Material;
    
        myCollider = gameObject.GetComponent<Collider>();
        playerTransform = Camera.main.transform;

        myTrigger = gameObject.GetComponent<EventTrigger>();

        if(myTrigger == null)
        {
            myTrigger = gameObject.AddComponent<EventTrigger>();
        }

        EventTrigger.Entry entryover = new EventTrigger.Entry();
        entryover.eventID = EventTriggerType.PointerEnter;
        entryover.callback.AddListener((eventData) => { OnPointerEnter(); });
        myTrigger.triggers.Add(entryover);

        EventTrigger.Entry entryout = new EventTrigger.Entry();
        entryover.eventID = EventTriggerType.PointerExit;
        entryover.callback.AddListener((eventData) => { OnPointerExit(); });
        myTrigger.triggers.Add(entryout);

    }
	
	// Update is called once per frame
	void Update () {

        if(interactionEnabled == false){

            return;

        }else if (outlineStatus == 1){
            if(outlineLerp< 1){
                outlineLerp += Time.deltaTime * outlineGrowSpeed;
                currentOutlineWidth = Mathf.Lerp(0f, outlineWidth, outlineLerp);
                outlineRenderer.material.SetFloat("_Outline", currentOutlineWidth);
            }
        }else if(outlineStatus == 2)
        {
            if(outlineLerp > 0f)
            {
                outlineLerp -= Time.deltaTime * outlineGrowSpeed;
                currentOutlineWidth = Mathf.Lerp(0f, outlineWidth, outlineLerp);
                outlineRenderer.material.SetFloat("_Outline", currentOutlineWidth);
            }
        }else if(outlineLerp <= 0f)
        {
            GameObject.Destroy(outlineObject);
            outlineStatus = 0;
            if (disableOnOutlineDestroy == true)
            {
                interactionEnabled = false;
                disableOnOutlineDestroy = false;
            }
        }



	
	}


    public void OnPointerEnter()
    {
        outlineStatus = 1;
        SpawnOutlineChild();
        isGazeAt = true;
    }

    public void OnPointerExit()
    {
        outlineStatus = 2;
        isGazeAt = false;
    }


    private void SpawnOutlineChild()
    {
        if (outlineObject != null)
        {
            GameObject.Destroy(outlineObject);
        }

        outlineObject = new GameObject(gameObject.name + "_Outline");
        outlineObject.transform.SetParent(transform);
        outlineObject.transform.localPosition = Vector3.zero;
        outlineObject.transform.localRotation = Quaternion.identity;
        outlineObject.transform.localScale = Vector3.one;
        outlineRenderer = outlineObject.AddComponent<MeshRenderer>();
        MeshFilter outlineFilter = outlineObject.AddComponent<MeshFilter>();
        outlineFilter.mesh = (Mesh)gameObject.GetComponent<MeshFilter>().mesh;
        outlineRenderer.material = outlineMaterial;
        outlineRenderer.material.SetFloat("_Outline", 0f);
        outlineLerp = 0;
         

    }

    public void DisableInteraction()
    {
        outlineStatus = 2;
        disableOnOutlineDestroy = true;
        myCollider.enabled = false;
    }









}
