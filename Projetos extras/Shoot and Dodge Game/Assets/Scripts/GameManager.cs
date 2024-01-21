using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    const float RestartDelay = 3f;

    public void EndGame()
    {
        Invoke("RestartGame", RestartDelay);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<RockSpawner>().Spawning = true;
    }
}
