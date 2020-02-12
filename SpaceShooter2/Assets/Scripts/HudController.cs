using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public GameManager manager;
    public Text txtScore;
    public Text txtLives;
	
	void Update ()
    {
        txtLives.text = "Lives : " + manager.lives;
        txtScore.text = "Score : " + manager.Score;
	}
}