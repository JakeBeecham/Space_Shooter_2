using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score = 0;
    public int lives = 3;
    public int killsToGainLife = 20;
    int currentKillCount = 0;

    public void AddToScore(int score)
    {
        Score += score;
        currentKillCount++;
        CheckForExtraLife();
    }

    public void SubtractLife()
    {
        lives--;

        if(lives <= 0)
        {
            SceneManager.LoadScene("mainmenu");
        }
    }

    void CheckForExtraLife()
    {
        if(currentKillCount >= killsToGainLife)
        {
            lives++;
            currentKillCount = 0;
        }
    }
}