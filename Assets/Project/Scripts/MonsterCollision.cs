using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollision : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerCollider")
        {
            this.transform.parent.GetComponent<Monster>().takeDamage(1000);
            //Debug.Log("COLLISIONE!!!");
        }
    }
}
