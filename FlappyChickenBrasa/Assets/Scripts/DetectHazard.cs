using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHazard : MonoBehaviour
{
    public LayerMask ground;
    public AudioSource smackSound;
    public AudioSource convertSound;
    bool isDie = false;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDie && collision.collider.CompareTag("hazard"))
        {
            this.isDie = true;
            this.GetComponent<Animator>().SetTrigger("die");
            Game.Instance.GameOver();
            smackSound.Play();
                Game.Instance.shake.ShakeCamera(.5f, 2.5f);

        }


        if (isDie)
        {
            if (collision.collider.CompareTag("hazardGround"))
            {
                this.GetComponent<Animator>().SetTrigger("die");
                this.gameObject.SetActive(false);
                GameObject explo = TrashMan.spawn("explo1", this.transform.position);
                convertSound.Play();
                Game.Instance.shake.ShakeCamera(.5f, 2.5f);
            }
        }
        else
        {
            this.isDie = true;
            if (collision.collider.CompareTag("hazardGround"))
            {
                this.GetComponent<Animator>().SetTrigger("die");
                Game.Instance.GameOver();
                this.gameObject.SetActive(false);
                GameObject explo = TrashMan.spawn("explo1", this.transform.position);
                convertSound.Play();
                Game.Instance.shake.ShakeCamera(.5f, 2.5f);

            }
        }
        

    }

    private void Update()
    {
       /* if(Physics2D.OverlapCircle(this.transform.position+Vector3.down*25, 4, ground))
        {
            this.gameObject.SetActive(false);
            GameObject explo = TrashMan.spawn("explo1", this.transform.position);
        }*/
    }
}
