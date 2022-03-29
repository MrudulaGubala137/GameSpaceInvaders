using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int health=50;
    PlayerMovement player;    
       
    public void PlayerHealth(int healthDec)
    {
        health = health - healthDec;
        Debug.Log(health);
    }
}
