using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int health;
    PlayerMovement player;
    public int score;
    public Text scoreText;
      public void Score(int value)
    {
        score=score+value;
        scoreText.text = "Score:" + score;
    }
    public void PlayerHealth(int healthDec)
    {
        health = health - healthDec;
        
        Debug.Log(health);
    }
}
