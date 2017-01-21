using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
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
        this.gameObject.SetActive(false);
        //this.gameObject.Destroy
    }





}
