using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DiePlayer diePlayer;
    public Flappy flappy;
    public DetectHazard detectHazard;

    private void Awake()
    {
        this.diePlayer = this.GetComponent<DiePlayer>();
        this.flappy = this.GetComponent<Flappy>();
        this.detectHazard = this.GetComponent<DetectHazard>();
    }

    public void OnDie()
    {
        flappy.RemoveControl();
    }
}
