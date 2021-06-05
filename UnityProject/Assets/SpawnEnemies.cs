using System;
using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using UnityEngine;
using UnityEngine.AI;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private List<EnemyInfo> enemies;

    [SerializeField] private List<SpawnInfo> spawns;

    [SerializeField] private int timeToStartWave = 5;

    [SerializeField] private IntVariable activeEnemies;

    [SerializeField] private Vector3 destination = new Vector3(150.5f, 10, 250);

    public int currentWave = 0;

    private int nActiveSpawns = 1;

    private void Start()
    {
        activeEnemies.value = 0;
    }

    private void Update()
    {
        if (activeEnemies.value <= 0)
        { 
            currentWave++;
          
            OnStartWave(timeToStartWave, GetEnemyCount(currentWave));
        }

        UpdateActiveSpawns(currentWave);
        
    }

    private void UpdateActiveSpawns(int currentWave)
    {

        switch (currentWave)
        {
            case 5:
            case 15:
            case 25:
            case 40:
            case 45:

                foreach (var s in spawns)
                { 
                    if (!s.isActive)
                    {
                        s.isActive = true;
                        ++nActiveSpawns;
                        return;
                    }
                }
                break;
        }
    }

    private int GetEnemyCount(int currentWave)
    {
        return ((currentWave / 10) * 2) + (currentWave % 10);
    }

    private IEnumerator Spwan(int timeToStartWave, float seconds, int count)
    {
        yield return new WaitForSeconds(timeToStartWave);


        while (count > 0)
        {
            // 1 - Decrement count of enemies to spawn
            count--;

            // 2 - Spawn enemies in all spawn points
            foreach (var s in spawns)
            {
                if (!s.isActive)
                    continue;

                // 2.2 Spawn enemy
                var newEnemy = Instantiate(enemies[0].enemy, s.position, Quaternion.Euler(0, 0, 0));
                newEnemy.GetComponent<NavMeshAgent>().SetDestination(destination);
                newEnemy.GetComponent<EnemyController>().destination = destination;

            }

            yield return new WaitForSeconds(seconds);
        }
    }

    public void OnStartWave(int timeToStartWave, int count)
    {

            activeEnemies.value+= (count*nActiveSpawns);

        StartCoroutine(Spwan(timeToStartWave, 0.5f, count));
    }
}
