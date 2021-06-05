using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnInfo", order = 3)]

public class SpawnInfo : ScriptableObject
{
    public bool isActive = false;
    public Vector3 position = Vector3.zero;
}
