using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health;
    public int dmg;
    private bool isDead;

    //private float timerSpawn;

    void Start()
    {
        isDead = false;

        //timerSpawn = Time.time;
    }

    void Update()
    {




        //CONTROLLA SE SEI RICICLABILE
        if (Utility.isRecyclable(this.gameObject.transform.position))
            this.Death();


    }

    public void takeDamage(int dmg)
    {
        this.health -= dmg;
        this.CheckIsDead();
    }

    public void CheckIsDead()
    {
        if (health <= 0)
        {
            isDead = true;
            this.Death();
        }
    }

    public void Death()
    {
        this.gameObject.Recycle();

        //this.gameObject.SetActive(false);
        //this.gameObject.Destroy
        //Debug.Log("MORTO!!!");

    }

    /*
    void OnBecameInvisible()
    {
        this.Death();
    }
    */


}
