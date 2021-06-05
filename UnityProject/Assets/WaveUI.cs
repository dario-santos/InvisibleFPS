using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveUI : MonoBehaviour
{
    [SerializeField] private SpawnEnemies spawnEnemies;
    [SerializeField] private Text spawnEnemiesText;


    private void Update()
        => spawnEnemiesText.text = spawnEnemies.currentWave.ToString();
}
