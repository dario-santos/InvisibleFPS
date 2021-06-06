using System.Collections;
using System.Collections.Generic;
using Unity.FPS.AI;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    [SerializeField] private IntVariable lives;
    [SerializeField] private IntVariable activeEnemies;

    private bool toAdd = true;

    private void OnTriggerEnter(Collider other)
    {
        if (lives.value > 0 && other.CompareTag("Enemy"))
        {
            if(toAdd)
            { 
                lives.value--;
                activeEnemies.value--;
            } 
            
            toAdd = !toAdd;
            Destroy(other.gameObject);
        }
    }
}
