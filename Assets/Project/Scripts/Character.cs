using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    public int attackDmg;
    public int physicalDmg;
    public int points;
	public int multiplier;
	public int maxHealth;

    private bool isDead;

    void Start()
    {
        isDead = false;
        points = 0;
    }

    void Update()
    {
		
    }

   
    public void Shoot(int dd)
    {

    }

    public void takeDamage(int dmg)
    {
		this.health -= dmg*multiplier;
        this.CheckIsDead();
        //Debug.Log("VITA = "+health);
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
