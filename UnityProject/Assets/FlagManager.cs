using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> spawnPoints;
    private int lastSpawn = -1;


    private void Start()
    {
        lastSpawn = Random.Range(0, 6);
        spawnPoints[lastSpawn].SetActive(true);
    }

    public void SpawnFlag()
    {
        // Verify if any flag is active

        foreach (var f in spawnPoints)
        {
            if (f.activeSelf)
                return;
        }

        int index = Random.Range(0, 6);
        if(lastSpawn == index)
            index = Random.Range(0, 6);

        lastSpawn = index;
        spawnPoints[index].SetActive(true);
    }
}
