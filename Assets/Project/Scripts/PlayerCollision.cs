using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip soundDamage;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MonsterCollider")
        {
            this.transform.parent.GetComponent<Character>().takeDamage(other.transform.parent.GetComponent<Monster>().physicalDmg);
            AudioSource.PlayClipAtPoint(soundDamage, transform.position);
        }
    }
}
