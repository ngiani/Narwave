using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int lives;
    public int dmg;
    private bool isDead;


    void Start()
    {
        isDead = false;
    }

    void Update()
    {
        //CONTROLLI
        //...
        //CONTROLLO CHE SPARA:
        //this.Shoot(dmg);


    }

    public void Shoot(int dd)
    {

    }

    public void Hitted(int dmg)
    {
        this.lives -= dmg;
        this.CheckIsDead();
    }

    public void CheckIsDead()
    {
        if (lives <= 0)
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
