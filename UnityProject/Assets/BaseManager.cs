using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    [SerializeField] private IntVariable lives;
    [SerializeField] private IntVariable activeEnemies;

    private void OnTriggerEnter(Collider other)
    {
        if (lives.value > 0 && other.CompareTag("Enemy"))
        { 
            lives.value--;
            activeEnemies.value--;
            Destroy(other.gameObject);
        }
    }
}
