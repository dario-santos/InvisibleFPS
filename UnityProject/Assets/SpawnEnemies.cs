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

    private void Update()
    {
        if (activeEnemies.value <= 0)
            OnStartWave(timeToStartWave, 5);
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
                newEnemy.GetComponent<NavMeshAgent>().SetDestination(new Vector3(210, 3, 304));
                
            }

            yield return new WaitForSeconds(seconds);
        }
    }

    public void OnStartWave(int timeToStartWave, int count)
    {
        activeEnemies.value+=count;

        StartCoroutine(Spwan(timeToStartWave, 0.5f, count));
    }
}
