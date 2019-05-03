using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePlayer : MonoBehaviour
{
    bool isDie = false;
    public AudioSource smackSound;
    public AudioSource convertSound;
    public LayerMask ground;

    public void OnDie()
    {
        if (this.isDie)
            return;

        this.isDie = true;
        this.GetComponent<Animator>().SetTrigger("die");
        this.smackSound.Play();
        this.GetComponent<Player>().OnDie();
        Game.Instance.OnPlayerDie();
        Game.Instance.shake.ShakeCamera(.5f, 2.5f);
    }

    public void GeneratePlate()
    {
        this.gameObject.SetActive(false);
        GameObject explo = TrashMan.spawn("explo1", this.transform.position);
        this.convertSound.Play();
        Game.Instance.shake.ShakeCamera(.5f, 2.5f);
    }


    private void Update()
    {
        if (isDie)
        {
            if (Physics2D.Raycast(this.transform.position, Vector2.down, 28.0f, ground) ||
                Physics2D.Raycast(this.transform.position + Vector3.left * 25, Vector2.down, 28.0f, ground) ||
                 Physics2D.Raycast(this.transform.position + Vector3.right * 25, Vector2.down, 28.0f, ground))
            {
                GeneratePlate();
            }
        }
    }
}
