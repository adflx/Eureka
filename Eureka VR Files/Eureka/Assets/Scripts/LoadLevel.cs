using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        AutoFade.LoadLevel("YourGameLevel", 3, 1, Color.black);
    }
}