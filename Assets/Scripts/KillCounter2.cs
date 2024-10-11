using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCounter2 : MonoBehaviour
{
    int kills = 0;

    public void AddKill()
    {
        kills++;
    }
    void Update()
    {
        if (kills >= 6) {
            SceneManager.LoadScene("Scenes/GameOver");
        }
    }
}
