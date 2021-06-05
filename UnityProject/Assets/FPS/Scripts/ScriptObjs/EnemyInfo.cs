using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemyInfo", order = 2)]
public class EnemyInfo : ScriptableObject
{
    [Range(0f, 1.0f)] public float probabilityToSpawn = 0.5f;
    public GameObject enemy = null;
}
