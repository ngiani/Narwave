using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollision : MonoBehaviour
{
    private float timerStart;
    private float timerDmg;

    void Start()
    {
        timerStart = Time.time;
        timerDmg = 1.0f;
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerCollider")
        {
            this.transform.parent.GetComponent<Monster>().takeDamage(100000);
            //Debug.Log("COLLISIONE!!!");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PlayerLaser")
        {
            if (Time.time >= timerStart + timerDmg)
            {
                timerStart = Time.time;
                this.transform.parent.GetComponent<Monster>().takeDamage(other.transform.GetComponentInParent<Character>().attackDmg);
            }
            
        }
    }




}
