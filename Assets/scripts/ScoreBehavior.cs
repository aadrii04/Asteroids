using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreBehavior : MonoBehaviour
{
    public int score;
    public UnityEvent<int> OnchangeScore;

    private void OnEnable()
    {
        ScoreUpdater.OnUpdateScore += AddScore; //con el += hacemos la subscripcion en este caso
    }

    private void OnDisable()
    {
        ScoreUpdater.OnUpdateScore -= AddScore; //con el -= hacemos la desubscripcion en este caso
    }
    private void Start()
    {
        RestartScore();
    }

    public void RestartScore()
    {
        score = 0;
        OnchangeScore.Invoke(score);
    }

    public void AddScore(int d)
    {
        score += d;
        OnchangeScore.Invoke(score);
    }

    
}
