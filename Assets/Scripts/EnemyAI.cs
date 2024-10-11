// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemyAI : MonoBehaviour
// {

//     [SerializeField]
//     private float move_speed = 100f;
//     private GameObject playerTarget;
//     // Update is called once per frame
//     void Update()
//     {
//         // Only move forward when we have a player target
//         if (playerTarget != null){
//             transform.LookAt(playerTarget.transform.position);
//             transform.position += transform.forward * move_speed * Time.deltaTime;
//         }
//     }

//     private void OnTriggerEnter(Collider other){
//         playerTarget = other.gameObject;
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    private float move_speed = 1f;
    private GameObject playerTarget;

    // Update is called once per frame
    void Update()
    {
        if (playerTarget != null)
        {
            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * move_speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        playerTarget = other.gameObject;
    }
}
