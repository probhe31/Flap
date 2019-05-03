using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{

    public float timeToGenerate;
    public float c_timeToGenerate;
    List<GameObject> pipes = new List<GameObject>();

    

    void Update()
    {
        if (!this.generating)
            return;

        this.c_timeToGenerate += Time.deltaTime;
        if (this.c_timeToGenerate > this.timeToGenerate)
        {
            this.c_timeToGenerate = 0;
            GeneratePipe();
        }
        
    }

    public void GeneratePipe()
    {
        GameObject pipe = TrashMan.spawn("pipe", new Vector3(230, 0, 0));
        pipe.GetComponent<Pipe>().ResetGO();

        pipes.Add(pipe);
        Vector3 newpos = pipe.transform.position;
        int factor = Random.Range(0, 100) < 50 ? 1 : -1;
        newpos.y += Random.Range(0, 15) * 10 * factor;
        pipe.transform.position = newpos;
    }


    public void StarGeneration()
    {
        this.generating = true;
    }

    bool generating = false;
    public void StopGeneration()
    {
        this.generating = false;
        for (int i = 0; i < pipes.Count; i++)
        {
            TrashMan.despawn(pipes[i]);
        }
    }
}
