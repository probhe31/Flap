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
    float angle = 0;

    void Start()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
        this.animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        if (!this.hasControl)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            

            rb.velocity = Vector2.up * velocity;
            this.flap = true;
            this.animator.SetTrigger("flap");
            this.wosh.Play();
        }

        if(this.flap && this.rb.velocity.y <= 0)
        {
            angle = Mathf.Lerp(0, -90, -rb.velocity.y / 800);
            this.flap = false;
        }
        else
        {
            angle = Mathf.Lerp(0, 90, rb.velocity.y / 800);
            
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }


    bool hasControl = true;
    public void RemoveControl()
    {
        this.hasControl = false;
    }

    public void ResetGO()
    {
        this.rb.simulated = false;
        this.hasControl = false;
        this.transform.localRotation = Quaternion.identity;
        this.transform.position = new Vector3(-100,0,0);
    }

    public void StartGame()
    {
        this.rb.simulated = true;
        this.hasControl = true;
    }

    public void EndGame()
    {
        this.rb.simulated = false;
        this.hasControl = false;
    }
}
