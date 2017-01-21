using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackC : MonoBehaviour
{
    public Monster monsterBulletC;
    public int bulletCount;
    private Monster bulletTmp;
    private float timerStart;
    public float timerAutoDanno;
    public int autoDanni;
    public float scaleFactor;
    private int startingHealth;
    private float reverseHealth;

    void Start()
    {
        timerStart = Time.time;
        startingHealth = gameObject.GetComponent<Monster>().health;
        reverseHealth = 0;
        //timerStopFireInt = Time.time + timerStopFire;
    }

    void Update()
    {
        
        //SI FA DANNI DA SOLO
        if (Time.time >= timerStart + timerAutoDanno)
        {
            timerStart = Time.time;
            this.AutoAttack();
        }

        //SI INGRANDISCE AL DIMINUIRE DELLA VITA
        reverseHealth = ((float)(startingHealth - gameObject.GetComponent<Monster>().health))/(startingHealth);
        float tmp2 = reverseHealth * scaleFactor;
        Debug.Log(gameObject.GetComponent<Monster>().health);
        transform.localScale += new Vector3(tmp2, tmp2, tmp2);
        

       



    }

    public void AutoAttack ()
    {
        this.gameObject.GetComponent<Monster>().takeDamage(autoDanni);
    }

    public void Attack ()
    {
        for (int i=0; i<bulletCount; i++)
        {
            bulletTmp = monsterBulletC.Spawn(transform.position);

            if (i == 0)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.up);
            else if (i == 1)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.down);
            else if (i == 2)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.left);
            else if (i == 3)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.right);
            else if (i == 4)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.right + Vector3.down);
            else if (i == 5)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.right + Vector3.up);
            else if (i == 6)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.left + Vector3.down);
            else if (i == 7)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.left + Vector3.up);
        }

        
        /*
        monsterBulletC.Spawn(new Vector3(0f, 1.0f, 0f)); // UP
        monsterBulletC.Spawn(new Vector3(0f, -1.0f, 0f)); // DOWN
        monsterBulletC.Spawn(new Vector3(-1.0f, 0f, 0f)); // LEFT
        monsterBulletC.Spawn(new Vector3(1.0f, 0f, 0f)); // RIGHT
        monsterBulletC.Spawn(new Vector3(1.0f, 1.0f, 0f));
        */
    }

}
