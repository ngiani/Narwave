using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float health;
    public float dmg;
    private bool isDead;

    void Start()
    {
        isDead = false;
    }

    void Update()
    {
		takeDamage (0.001f);
    }

   
    public void Shoot(int dd)
    {

    }

    public void takeDamage(float dmg)
    {
        this.health -= dmg;
        this.CheckIsDead();
        Debug.Log("VITA = "+health);
    }

    public void CheckIsDead()
    {
        if (health <= 0)
        {
            isDead = true;
        }
    }

    public void Death()
    {
        //Spawna la bolla
        //this.gameObject.SetActive(false);
    }





}
