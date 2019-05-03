using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Game : MonoBehaviour
{
    public static float gVelocity = 300;
    public static Game Instance;
    [HideInInspector]
    public ScoreCounter scoreCounter;
    public Player player;
    public LevelGeneration levelGeneration;
    public CameraShakeV2 shake;
    bool wasInitGame = false;

    private void Awake()
    {
        Instance = this;
        this.scoreCounter = this.GetComponent<ScoreCounter>();
        this.levelGeneration = this.GetComponent<LevelGeneration>();
    }


    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            InitGame();
        }
    }

    public void OnPlayerDie()
    {
        gVelocity = 0;
        this.levelGeneration.StopGeneration();
    }

    public void ShowGameOverPopup()
    {

    }


    public void Restart()
    {
        this.player.flappy.ResetGO();
        this.wasInitGame = false;
        scoreCounter.ResetScore();
        gVelocity = 300.0f;
        player.gameObject.SetActive(true);
    }

    public void InitGame()
    {
        wasInitGame = true;
        player.flappy.StartGame();
        levelGeneration.StarGeneration();
    }
}
