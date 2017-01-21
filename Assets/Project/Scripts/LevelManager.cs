﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float timerSpawn;
    public Monster monsterA;
    //public Vector3 spawnPoint;
    private float timerStart;
    private Vector3 spawnPoint1;
    private Vector3 spawnPoint2;
    private Vector3 realSpawnPoint; 

	void Start ()
    {
        timerStart = Time.time;
        Camera camera = Camera.main;
        spawnPoint1 = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        spawnPoint2 = camera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f));
    }
	
	void Update ()
    {






        //TEST SPAWN MOSTRI
        if (Time.time >= timerStart + timerSpawn)
        {
            float randomY = Random.Range(spawnPoint2.y, spawnPoint1.y);
            realSpawnPoint = new Vector3(spawnPoint1.x, randomY, spawnPoint1.z);
            timerStart = Time.time;
            monsterA.Spawn(realSpawnPoint);

            
        }
       



    }



}
