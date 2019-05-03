using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public float velocity = 1;
    Rigidbody2D rb;
    Animator animator;
    bool flap = false;
    public AudioSource wosh;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
        this.animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.hasControl)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            //this.transform.eulerAngles = new Vector3(0, 0, 30);
            this.flap = true;
            this.animator.SetTrigger("flap");
            this.wosh.Play();
        }

        if(this.flap && this.rb.velocity.y < 0)
        {
            this.flap = false;
            //this.transform.eulerAngles = new Vector3(0, 0, -30);
        }
            

    }


    bool hasControl = true;
    public void RemoveControl()
    {
        this.hasControl = false;
    }
}
