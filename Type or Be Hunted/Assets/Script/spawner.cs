﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] Enemy;

    private int zpos1;
    private int xpos1;
    private int zpos2;
    private int xpos2;
    private int zpos3;
    private int xpos3;
    private int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while (EnemyCount < 3)
        {
            xpos1 = Random.Range(-493, -227);
            zpos1 = Random.Range(-93, 17);
            xpos2 = Random.Range(-56,68);
            zpos2 = Random.Range(-64,61);
            xpos3 = Random.Range(-118, -7);
            zpos3 = Random.Range(208, 472);
            int rand = Random.Range(0,Enemy.Length);
<<<<<<< HEAD
            Instantiate(Enemy[rand], new Vector3(xpos1, 21, zpos1), Quaternion.identity);
            Instantiate(Enemy[rand], new Vector3(xpos2, 21, zpos2), Quaternion.identity);
            Instantiate(Enemy[rand], new Vector3(xpos3, 21, zpos3), Quaternion.identity);
=======
            Instantiate(Enemy[rand], new Vector3(xpos1, 16, zpos1), Quaternion.identity);
            /*Instantiate(Enemy[rand], new Vector3(xpos2, 16, zpos2), Quaternion.identity);
            Instantiate(Enemy[rand], new Vector3(xpos3, 16, zpos3), Quaternion.identity);*/
>>>>>>> parent of 79a76f3 (knockback dll)
            SoundManager.instance.TuyulSpawn();
            yield return new WaitForSeconds(2);
            
            EnemyCount += 1;
        }
    }
}
