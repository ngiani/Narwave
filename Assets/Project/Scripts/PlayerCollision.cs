using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MonsterCollider")
        {
            this.transform.parent.GetComponent<Character>().takeDamage(other.transform.parent.GetComponent<Monster>().physicalDmg);
            //Debug.Log("COLLISIONE!!!");
        }
    }
}
