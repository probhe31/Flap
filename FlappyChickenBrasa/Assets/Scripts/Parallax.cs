using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject bg1;
    public GameObject bg2;
    public float offset = 1;

    private void Awake()
    {
        
    }

    private void Update()
    {
        bg1.transform.position += Vector3.left * Game.gVelocity * Time.deltaTime * this.offset;
        bg2.transform.position += Vector3.left * Game.gVelocity * Time.deltaTime * this.offset;

        if (bg1.transform.position.x < -360)
            bg1.transform.position = bg2.transform.position + Vector3.right * 360;

        if (bg2.transform.position.x < -360)
            bg2.transform.position = bg1.transform.position + Vector3.right * 360;
    }
}
