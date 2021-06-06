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

    [SerializeField] private List<GameObject> spawnPortals;

    [SerializeField] private int timeToStartWave = 5;

    [SerializeField] private IntVariable activeEnemies;

    [SerializeField] private IntVariable waveCount;

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

            waveCount.value = currentWave;

            UpdateActiveSpawns(currentWave);

            OnStartWave(timeToStartWave, GetEnemyCount(currentWave));
        }
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

                for (int i = 0; i < spawns.Count; i++)
                { 
                    if (!spawns[i].isActive)
                    {
                        spawns[i].isActive = true;
                        spawnPortals[i].SetActive(true);
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

    private IEnumerator Spwan(int timeToStartWave, float seconds, int count, int currentWave)
    {
        yield return new WaitForSeconds(timeToStartWave);


        // 1 - Spawn enemies in all spawn points
        foreach (var s in spawns)
        {
            if (s.isActive)
            {
                for (int i = 0; i < count; i++)
                {       
                    // 2.2 - Spawn enemy
                    var newEnemy = Instantiate(enemies[0].enemy, s.position, Quaternion.Euler(0, 0, 0));
                    newEnemy.GetComponent<NavMeshAgent>().SetDestination(destination);
                    newEnemy.GetComponent<EnemyController>().destination = destination;

                    yield return new WaitForSeconds(seconds);
                }

                // 2.3 - Spawn OMEGA enemy in special waves
                if (currentWave % 5 == 0)
                {
                    // 2.2 - Spawn OMEGA enemy
                    var omega = Instantiate(enemies[1].enemy, s.position, Quaternion.Euler(0, 0, 0));
                    omega.GetComponent<NavMeshAgent>().SetDestination(destination);
                    omega.GetComponent<EnemyController>().destination = destination;
                }
            }
        }
    }

    public void OnStartWave(int timeToStartWave, int count)
    {
        activeEnemies.value += (count*nActiveSpawns);
     
        if (currentWave % 5 == 0)
            activeEnemies.value += nActiveSpawns;

        StartCoroutine(Spwan(timeToStartWave, 0.5f, count, currentWave));
    }
}
