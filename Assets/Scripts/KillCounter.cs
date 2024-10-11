using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCounter : MonoBehaviour
{
    int kills = 0;

    public void AddKill()
    {
        kills++;
    }
    void Update()
    {
        if (kills >= 4) {
            SceneManager.LoadScene("Scenes/Level2Screen");
        }
    }
}
