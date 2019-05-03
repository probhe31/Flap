using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    int score = 0;
    public HudText hudScore;
    public AudioSource scoreSound;

    public void ResetScore()
    {
        score = 0;
    }

    public void AddPoint()
    {
        this.score++;
        this.hudScore.SetText(this.score);
        this.scoreSound.Play();
    }
}
