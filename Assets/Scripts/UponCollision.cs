using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;

public class UponCollision : MonoBehaviour
{
    public AudioClip impactSFX;
    public GameObject particleSFX;
    
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().PlayOneShot(impactSFX);
        Instantiate(particleSFX, transform.position, Quaternion.identity);
    }
}