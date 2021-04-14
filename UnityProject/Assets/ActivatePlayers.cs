using UnityEngine;

public class ActivatePlayers : MonoBehaviour
{
    [Header("Players Objects")]
    public GameObject PlayerRed;
    public GameObject PlayerBlue;
    public GameObject PlayerYellow;
    public GameObject PlayerGreen;

    [Header("Player Info")]
    public PlayerInfo PlayerInfoRed;
    public PlayerInfo PlayerInfoBlue;
    public PlayerInfo PlayerInfoYellow;
    public PlayerInfo PlayerInfoGreen;

    private void Awake()
    {
        PlayerRed.SetActive(PlayerInfoRed.playerIndex != -1);
        PlayerBlue.SetActive(PlayerInfoBlue.playerIndex != -1);
        PlayerYellow.SetActive(PlayerInfoYellow.playerIndex != -1);
        PlayerGreen.SetActive(PlayerInfoGreen.playerIndex != -1);
    }
}
