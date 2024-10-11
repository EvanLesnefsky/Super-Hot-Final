// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class GameOver : MonoBehaviour
// {
//     private void OnTriggerEnter(Collider other){
//         if (other.gameObject.tag == "EnemyHitBox" || other.gameObject.tag == "EnemyBullet"){
//             string currentSceneName = SceneManager.GetActiveScene().name;
//             SceneManager.LoadScene(currentSceneName);
//         }
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game2Over : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyHitBox")
        {
            ResetGame();
        }
        if (other.gameObject.tag == "BulletHitBox")
        {
            ResetGame();
        }
    }
    private void ResetGame()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Scenes/KillScreen2");
    }
}
