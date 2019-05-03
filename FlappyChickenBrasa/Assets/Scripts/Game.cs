using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static float gVelocity = 300;
    public static Game Instance;
    [HideInInspector]
    public ScoreCounter scoreCounter;
    public GameObject player;
    public LevelGeneration levelGeneration;
    public CameraShakeV2 shake;

    private void Awake()
    {
        Instance = this;
        this.scoreCounter = this.GetComponent<ScoreCounter>();
        this.levelGeneration = this.GetComponent<LevelGeneration>();
    }


    private void Start()
    {
        levelGeneration.StarGeneration();
    }

    public void GameOver()
    {
        
        this.player.GetComponent<Flappy>().RemoveControl();
        gVelocity = 0;
        levelGeneration.StopGeneration();
    }
}
