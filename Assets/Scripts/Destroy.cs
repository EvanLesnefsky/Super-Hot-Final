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
public class Destroy : MonoBehaviour
{
    public KillCounter killCounterScript;
    // public GameObject particleSFX;
    // public AudioClip impactSFX;

    void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
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