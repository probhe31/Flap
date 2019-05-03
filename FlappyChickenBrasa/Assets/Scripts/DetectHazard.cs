using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHazard : MonoBehaviour
{



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("hazard"))
        {
            this.GetComponent<Player>().diePlayer.OnDie();
        }
    }

   


    
}
