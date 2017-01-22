﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int health;
    public int attackDmg;
    public int physicalDmg;
    public int pointValue;
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
        if (this.gameObject.tag == "MonsterC")
        {
            this.gameObject.GetComponent<AttackC>().Attack();
        }
        GetComponentInChildren<Animator>().SetBool("Dead", true);
        StartCoroutine(RecycleAfterSeconds(1f));//this.gameObject.Recycle();

        //this.gameObject.SetActive(false);
        //this.gameObject.Destroy
        //Debug.Log("MORTO!!!");

    }

    private IEnumerator RecycleAfterSeconds(float s)
    {
        yield return new WaitForSeconds(s);
        gameObject.Recycle();
    }

    /*
    void OnBecameInvisible()
    {
        this.Death();
    }
    */


}
