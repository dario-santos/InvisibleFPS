using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerInfo", order = 1)]
public class PlayerInfo : ScriptableObject
{
    public int playerIndex = -1;
    public bool isActive = false;
    public int kills = 0;
    public int deaths = 0;
    public Color color = Color.gray;

    public void Reset() 
    {
        playerIndex = -1;
        isActive = false;
        kills = 0;
        deaths = 0;
    }
}
