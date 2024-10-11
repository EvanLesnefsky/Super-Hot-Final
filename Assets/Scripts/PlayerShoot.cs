using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Audio;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BulletTemplate;
    public float shootPower = 100f;
    public AudioClip gunShotSFX;
    
    public InputActionReference trigger;
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext __)
    {
        GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
        GetComponent<AudioSource>().PlayOneShot(gunShotSFX);
    }

    // private void OnTriggerEnter(Collider other){
    //     if (other.gameObject.CompareTag("EnemyHitBox"))
    //     {
    //         Destroy(other.transform.parent.gameObject);
    //     }
    //     if (!other.gameObject.CompareTag("Player"))
    //     {
    //         Destroy(gameObject);
    //     }
    // }
}
