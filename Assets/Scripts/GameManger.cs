using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    private int score;
    public void IncreaseScore()
    {
        score++;
    }
    public void GameOver()
    {
        Debug.Log("Game over");
        pause();
    }

    public void pause()
    {
        Time.timeScale = 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
