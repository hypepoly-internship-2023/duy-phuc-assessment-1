using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private bool gameOver = false;

    [SerializeField] private float restartDelay = 1f;

    void Awake()
    {
        instance = this;    
    }

    public void EndGame()
    {
        if(!gameOver)
        {
            gameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
