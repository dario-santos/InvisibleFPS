using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerInfo", order = 1)]
public class PlayerInfo : ScriptableObject
{
    public int playerIndex = -1;
    public bool isActive = false;

    public void Reset() 
    {
        playerIndex = -1;
        isActive = false;

    }
}
