using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    public int attackDmg;
    public int physicalDmg;
    public int points;
	private int multiplier;
    public int maxMultiplier = 4;
	public int maxHealth;

    private bool isDead;

    public int Multiplier
    {
        get { return multiplier; }
        set
        {
            if (value <= maxMultiplier && value >= 0)
                multiplier = value;
        }
    }

    void Start()
    {
        isDead = false;
        points = 0;
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
            GetComponentInChildren<Animator>().SetBool("Dead", true);
            GetComponent<InputController>().enabled = false;
            
        }
    }

    private IEnumerator PutAwayAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        transform.position = new Vector3(0, -100f, 0);
    }

    public void Death()
    {
        //Spawna la bolla
        //this.gameObject.SetActive(false);
    }





}
