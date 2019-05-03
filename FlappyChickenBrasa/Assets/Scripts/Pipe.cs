using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject pipeTop;
    public GameObject pipeBottom;
    bool count = false;

    

    private void Update()
    {
        this.transform.position += Vector3.left * Game.gVelocity * Time.deltaTime;

        if(!this.count && this.transform.position.x < Game.Instance.player.transform.position.x)
        {
            this.count = true;
            Game.Instance.scoreCounter.AddPoint();
        }


        if (this.transform.position.x < -300)
            Kill();

        
    }

    public void Kill()
    {
        TrashMan.despawn(this.gameObject);
    }

    public void ResetGO()
    {
        this.count = false;
        Vector3 posT = new Vector3(this.transform.position.x, 320f);
        Vector3 posB = new Vector3(this.transform.position.x, -320f);
        pipeTop.transform.position = posT;
        pipeBottom.transform.position = posB;

    }
}
