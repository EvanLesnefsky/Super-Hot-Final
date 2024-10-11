using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;

// public class Destroy : MonoBehaviour
// {
//     // public AudioClip impactSFX;
    
//     void OnCollisionEnter(Collision collision)
//     {
//         // GetComponent<AudioSource>().PlayOneShot(impactSFX);
//         Destroy(gameObject);
//         Debug.Log("Target eliminated!");
//     }
// }
public class Destroy2 : MonoBehaviour
{
    public KillCounter2 killCounterScript;
    // public GameObject particleSFX;
    // public AudioClip impactSFX;

    void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter2>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // GetComponent<AudioSource>().PlayOneShot(impactSFX);
        // Instantiate(particleSFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
        killCounterScript.AddKill();
        Debug.Log("Target eliminated!");
    }
}