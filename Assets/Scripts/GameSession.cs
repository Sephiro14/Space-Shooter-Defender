using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int score = 0;

    private void Awake()
    {
        SetUpSingleton();
    }

    //Ne detruit pas malgré le changement de scene. Un Singleton rend un objet unique a travers le jeu entier sans perdre les informations de la classe.
    private void SetUpSingleton()
    {
        int NumbersGameSession = FindObjectsOfType<GameSession>().Length;
        if(NumbersGameSession > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
